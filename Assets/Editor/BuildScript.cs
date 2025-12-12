using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void BuildiOS()
    {
        string path = "build/ios";

        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = GetEnabledScenes();
        options.locationPathName = path;
        options.target = BuildTarget.iOS;
        options.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(options);
    }

    private static string[] GetEnabledScenes()
    {
        var scenes = EditorBuildSettings.scenes;
        var enabled = new System.Collections.Generic.List<string>();

        foreach (var s in scenes)
        {
            if (s.enabled)
                enabled.Add(s.path);
        }

        return enabled.ToArray();
    }
}
