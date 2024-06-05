using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berhenti : MonoBehaviour
{
    public GameObject ResumeBtn;
    public GameObject PauseBtn;
    // Start is called before the first frame update
    void Start()
    {
        ResumeBtn.SetActive(false);
    }
    public void pause()
    {
        ResumeBtn.SetActive(true);
        Time.timeScale = 0;
        PauseBtn.SetActive(false);
    }
}
