using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject pauseMenuUI;
    public GameObject settingsMenu;
    public GameObject subtitles;
    public GameObject player;

    private void Start()
    {
        GameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        subtitles.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        subtitles.SetActive(false);

    }

    public void SettingsMenu()
    {
        pauseMenuUI.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void SaveGame()
    {
        player.GetComponent<PlayerInformation>().SavePlayer();
    }

    public void LoadGame()
    {
        player.GetComponent<PlayerInformation>().LoadPlayer();
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu"); // Quits to the main menu
    }

}
