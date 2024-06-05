using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Exiting game");
        Application.Quit(); // This function works in standalone builds
    }
}

