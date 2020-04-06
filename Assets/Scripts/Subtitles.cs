using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public GameObject textBox;
    public GameObject player;

    public void setText(string dialogue)
    {
        if(player.GetComponent<PlayerInformation>().subtitlesEnabled) // If subtitles are enabled, display them. Otherwise, don't.
        {
            textBox.GetComponent<Text>().text = dialogue;
        }
        else
        {
            textBox.GetComponent<Text>().text = "";
        }
    }
}
