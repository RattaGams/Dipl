using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Test Szene");
    }

    public void QuitGameWappler()
    {
        Application.Quit();
    }

    
}