using UnityEditor;
using UnityEngine;
using System.IO;

//[InitializeOnLoad]
/*
public class ReadmeOnStart
{
    private const string readmeFilePath = "Assets/Readme/README.md";
    private const string hasShownReadmeKey = "HasShownReadme"; 
    static ReadmeOnStart()
    {
        EditorApplication.update += ShowReadmeOnStart;

        EditorApplication.quitting += ResetReadmeOnQuit;
    }
    static void ShowReadmeOnStart()
    {
        EditorApplication.update -= ShowReadmeOnStart;

        if (!EditorPrefs.GetBool(hasShownReadmeKey, false))
        {
                Application.OpenURL("file://" + Path.GetFullPath(readmeFilePath));
                EditorPrefs.SetBool(hasShownReadmeKey, true);
        }
    }
    static void ResetReadmeOnQuit()
    {

        EditorPrefs.SetBool(hasShownReadmeKey, false);
    }
}
*/