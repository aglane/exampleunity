  using UnityEngine;
	using UnityEditor;
	using UnityEditor.Callbacks;
	
	public static class PostBuildTrigger {
		[PostProcessBuild]
		public static void OnPostprocessBuild(BuildTarget target, string path) {
		  string projectParent = (Directory.GetParent(Application.dataPath).ToString();
		  string buildName = Path.GetFileNameWithoutExtension(path);
			Debug.Log( "ProjectParent: " + projectParent + " build: " + buildName );
    	}
	}
