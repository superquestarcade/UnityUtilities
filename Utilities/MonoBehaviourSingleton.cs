using UnityEngine;

namespace Metatron.PixelElements
{
	/// <summary>
	/// A generic base class designed to make singleton building easier.
	/// </summary>
	/// <typeparam name="T">The inheriting class</typeparam>
	public class MonoBehaviourSingleton<T> : MonoBehaviourPlus where T : class
	{
		public static T singleton { get; private set; }
		public bool dontDestroyOnLoad = true;

		public virtual void Awake()
		{
			InitializeSingleton();
		}

		private bool InitializeSingleton()
		{
			if (singleton != null && singleton == this as T) return true;
			if (dontDestroyOnLoad)
			{
				if (singleton != null)
				{
					if (DebugMessages)
						Debug.LogWarning(
							$"Multiple {name} detected in the scene. Only one {name} can exist at a time. The duplicate {name} will be destroyed.");
					Destroy(gameObject);

					// Return false to not allow collision-destroyed second instance to continue.
					return false;
				}

				if (DebugMessages) Debug.Log($"{name} created singleton (DontDestroyOnLoad)");
				singleton = this as T;
				transform.SetParent(null);
				if (!Application.isPlaying) return true;
#if UNITY_EDITOR
				// This is to fix an inconsequential editor bug
				UnityEditor.SceneVisibilityManager.instance.Show(gameObject, false);
#endif
				DontDestroyOnLoad(gameObject);
			}
			else
			{
				if (DebugMessages) Debug.Log($"{name} created singleton (ForScene)");
				singleton = this as T;
			}

			return true;
		}
	}
}