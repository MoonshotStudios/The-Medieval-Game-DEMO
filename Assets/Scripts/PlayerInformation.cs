using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInformation : MonoBehaviour
{
    public bool subtitlesEnabled;
    public string level;

    // Start is called before the first frame update
    void Start()
    {
        subtitlesEnabled = false;
        level = SceneManager.GetActiveScene().name;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.loadPlayer();
        subtitlesEnabled = data.subtitlesEnabled;
        if(!SceneManager.GetActiveScene().name.Equals(data.level))
        {
            SceneManager.LoadScene(data.level);
        }
    }
}
