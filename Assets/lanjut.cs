using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanjut : MonoBehaviour
{
    public GameObject ResumeBtn;
    public GameObject PauseBtn;
    public void resume(){
        Time.timeScale = 1;
        ResumeBtn.SetActive(false);
        PauseBtn.SetActive(true);
    }
}
