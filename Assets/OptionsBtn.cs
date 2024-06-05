using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsBtn : MonoBehaviour{
     public void LoadScene(string Options)
    {

        SceneManager.LoadScene(Options);
    }

}