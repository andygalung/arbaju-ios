using UnityEditor;

public static class BuildScript
{
    public static void BuildiOS()
    {
        string path = "build/ios";

        BuildPlayerOptions opts = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/SampleScene.unity" }, // ganti sesuai scene kakak
            locationPathName = path,
            target = BuildTarget.iOS,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(opts);
    }
}
