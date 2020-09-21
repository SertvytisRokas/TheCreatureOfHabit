using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVL1PauseController : MonoBehaviour
{
    public static bool isGamePaused = false;
    bool isSettings = false;

    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {

                Resume();

            }
            if (isSettings)
            {
                Pause();
            }
            else
            {

                Pause();

            }
        }

    }

    public void Resume()
    {
        settingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        isSettings = false;
    }

    public void Pause()
    {
        settingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        isSettings = false;
    }

    public void Settings()
    {
        isSettings = true;
        isGamePaused = true;
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        Cursor.visible = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
