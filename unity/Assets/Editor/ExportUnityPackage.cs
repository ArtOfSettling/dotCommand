using UnityEditor;

public static class BuildScript {
    public static void ExportUnityPackage() {
        AssetDatabase.ExportPackage("Assets/WellFired", "WellFired.Command.unitypackage", ExportPackageOptions.Recurse);
    }
}