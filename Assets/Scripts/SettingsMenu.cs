using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject subtitlesButton;

    private void Start()
    {

    }

    private void Update()
    {
        subtitlesButton.GetComponent<Text>().text = "SUBTITLES: " + ((player.GetComponent<PlayerInformation>().subtitlesEnabled) ? "enabled" : "disabled");
    }

    public void Back()
    {
        pauseMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void Subtitles() // Toggles subtitles
    {
        player.GetComponent<PlayerInformation>().subtitlesEnabled = !player.GetComponent<PlayerInformation>().subtitlesEnabled;
    }
}
