using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public bool subtitlesEnabled;
    public string level;

    public PlayerData(PlayerInformation playerInfo)
    {
        subtitlesEnabled = playerInfo.subtitlesEnabled;
        level = playerInfo.level;
    }
}
