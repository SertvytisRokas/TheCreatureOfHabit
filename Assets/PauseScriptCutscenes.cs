using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScriptCutscenes : MonoBehaviour
{
    public static bool isGamePaused = false;
    bool isSettings = false;

    public GameObject pauseMenu;
    public GameObject settingsMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isGamePaused) {
                Resume();
            }
            if (isSettings)
            {
                Pause();
            }
            else {
                Pause();
            }
        }
    }

    public void Resume() {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(false);
        isGamePaused = false;
        isSettings = false;
    }

    public void Pause()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
        isGamePaused = true;
        isSettings = false;
    }

    public void Settings() {
        settingsMenu.SetActive(true);
        pauseMenu.SetActive(false);
        isGamePaused = true;
        isSettings = true;
    }

    public void Quit() {
        Application.Quit();
    }
}
