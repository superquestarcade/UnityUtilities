Some Unity utility files I use a lot. The plan is to add a bunch of other stuff I use or have picked up along the way that comes with me into most projects
MonoBehaviourPlus.cs
This class adds a simple set of debug levels & conditions so I can set the level of debug messages in the inspector; "Minimal", "Moderate", "All" I use this mostly to adjust levels of detail on debug output to the console because I don't like having my console flooded with debug logs all the time

MonoBehaviourSingleton.cs
This is a singleton constructor I use to build all my singletons safely, so far I've used it in every project
	
UnityUtils2.unitypackage
Scene change management & global singleton boot utilities. I need to clean this up so it's more usable plus I've made some updates
