using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using System;

public class MenuCode : MonoBehaviour
{

    public GameObject PausePanel;
    public GameObject GamePanel;
    public GameObject MusicOn, MusicOff;

    public AudioSource GameMusic;

    public void PauseButton()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        GamePanel.SetActive(false);
    }
    public void ResumeButton()
    {
        PausePanel.SetActive(false);
        GamePanel.SetActive(true);
        Time.timeScale = 1f;
    }
    
    public void MusicOnButton()
    {
        MusicOn.SetActive(false);
        MusicOff.SetActive(true);
        GameMusic.mute = true;
    }

    public void MusicOffButton()
    {
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
        GameMusic.mute = false;
    }

    public void ReplayButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitMenuButton()
    {
        SceneManager.LoadScene("anaMenu");
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
