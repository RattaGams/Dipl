using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class BackToTitleScreen : MonoBehaviour
{
    // Input action reference for the secondary button
    [SerializeField] private InputActionReference secondaryButtonAction;

    private void OnEnable()
    {
        // Subscribe to the input action's performed event
        if (secondaryButtonAction != null)
        {
            secondaryButtonAction.action.performed += OnSecondaryButtonPressed;
        }
    }

    private void OnDisable()
    {
        // Unsubscribe from the input action's performed event
        if (secondaryButtonAction != null)
        {
            secondaryButtonAction.action.performed -= OnSecondaryButtonPressed;
        }
    }

    private void OnSecondaryButtonPressed(InputAction.CallbackContext context)
    {
        // Load the title screen scene (replace "TitleScreen" with your scene name)
        SceneManager.LoadScene("MainMenu");
    }

    public static void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
