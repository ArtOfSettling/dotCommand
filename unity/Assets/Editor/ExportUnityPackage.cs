using UnityEditor;

public static class BuildScript {
    public static void ExportUnityPackage() {
        AssetDatabase.ExportPackage("Packages/com.phantombit.command", "WellFired.Command.unitypackage", ExportPackageOptions.Recurse);
    }
} 