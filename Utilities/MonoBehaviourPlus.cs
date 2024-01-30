using UnityEngine;

namespace Metatron
{
	public class MonoBehaviourPlus : MonoBehaviour
	{
		public DebugLevel debugLevel;
		public bool DebugMessages => debugLevel > DebugLevel.None;
	}

	public enum DebugLevel
	{
		None,
		Minimum,
		Moderate,
		All
	}
}