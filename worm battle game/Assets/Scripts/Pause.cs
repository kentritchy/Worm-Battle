using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour

{
    public static bool gameIsPaused = false;
    public GameObject PauseMenuUI, GameOverMenuUI, LeftKey, RightKey, ShootKey;


    public AudioSource buttonClick;


    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        LeftKey.SetActive(true);
        RightKey.SetActive(true);
        ShootKey.SetActive(true);
        buttonClick.Play();
    }
    public void Pauze()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        LeftKey.SetActive(false);
        RightKey.SetActive(false);
        ShootKey.SetActive(false);
        buttonClick.Play();
        gameIsPaused = true;
    }


    public void Retry()
    {
        GameOverMenuUI.SetActive(false);
        buttonClick.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("retry");
    }

    public void Quit()
    {
        buttonClick.Play();
        Application.Quit();
        Debug.Log("quit");
    }
}
