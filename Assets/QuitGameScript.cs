using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGameScript : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        // If running in the Unity Editor, stop play mode
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // If running in a standalone build, quit the application
            Application.Quit();
#endif
    }
}