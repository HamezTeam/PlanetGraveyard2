using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Platformer
{
    public class GameBuilder : MonoBehaviour
    {
        [MenuItem("Build/Build macOS")]
        public static void PerformMacOSBuild()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
            buildPlayerOptions.locationPathName = "build/macOS/PlanetGraveyard2.app";
            buildPlayerOptions.target = (BuildTarget)9;
            buildPlayerOptions.options = BuildOptions.None;

            BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            BuildSummary summary = report.summary;
            
            if (summary.result == BuildResult.Succeeded)
                Debug.Log("Build succeeded" + summary.totalSize + "bytes");
            
            if (summary.result == BuildResult.Failed)
                Debug.Log("Build failed");
        }
        
        [MenuItem("Build/Build WebGL")]
        public static void PerformWebGLBuild()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
            buildPlayerOptions.locationPathName = "build/WebGL";
            buildPlayerOptions.target = (BuildTarget)20;
            buildPlayerOptions.options = BuildOptions.None;

            BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            BuildSummary summary = report.summary;
            
            if (summary.result == BuildResult.Succeeded)
                Debug.Log("Build succeeded" + summary.totalSize + "bytes");
            
            if (summary.result == BuildResult.Failed)
                Debug.Log("Build failed");
        }
    }
}