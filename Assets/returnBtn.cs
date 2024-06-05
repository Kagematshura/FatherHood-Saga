using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnBtn : MonoBehaviour
{
    // Function to be called when the button is clicked
    public void LoadScene(string Menu)
    {
        // Load the scene with the specified name
        SceneManager.LoadScene(Menu);
    }
}

