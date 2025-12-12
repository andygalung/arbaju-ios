using UnityEditor;
using UnityEngine;

public static class BuildScript
{
    public static void BuildiOS()
    {
        string path = "build/ios";
        BuildPlayerOptions options = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/Main.unity" },
            locationPathName = path,
            target = BuildTarget.iOS,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(options);
    }
}
