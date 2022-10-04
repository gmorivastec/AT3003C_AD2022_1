using UnityEditor;

public class Builder
{

    [MenuItem("Build/Windows")]
    public static void BuildWindows() {

        // objetivo: detonar construcción de binario de windows desde un menú 
        // del editor

        // [] - arreglo (array)
        // estructura que contiene varios valores del mismo tipo

        // primero obtengo la escenas
        EditorBuildSettingsScene[] escenitas = EditorBuildSettings.scenes;

        // segundo ejecuto la construcción
        BuildPipeline.BuildPlayer(
            escenitas, 
            "./bin/windows/Ejemplo.exe", 
            BuildTarget.StandaloneWindows64,
            BuildOptions.ShowBuiltPlayer
        );
    }    

    [MenuItem("Build/MacOS")]
    public static void BuildMacOS() {

        EditorBuildSettingsScene[] escenitas = EditorBuildSettings.scenes;
        BuildPipeline.BuildPlayer(
            escenitas, 
            "./bin/mac/Ejemplo.app", 
            BuildTarget.StandaloneOSX,
            BuildOptions.ShowBuiltPlayer
        );
    }

    [MenuItem("Build/Linux")]
    public static void BuildLinux(){

        EditorBuildSettingsScene[] escenitas = EditorBuildSettings.scenes;
        BuildPipeline.BuildPlayer(
            escenitas, 
            "./bin/linux/Ejemplo", 
            BuildTarget.StandaloneLinux64,
            BuildOptions.ShowBuiltPlayer
        );
    }
}
