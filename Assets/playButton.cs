using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    // Function to be called when the button is clicked
    public void LoadScene(string Game)
    {
        // Load the scene with the specified name
        SceneManager.LoadScene(Game);
    }
}

