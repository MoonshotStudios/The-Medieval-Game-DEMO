using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Here is where you'd declare your audio stuff, but the lines haven't been recorded yet, so for now it will be text.
    [SerializeField] string dialogue;
    public GameObject player;
    [SerializeField] private bool triggered;
    public GameObject m_canvas;
    public QuestTracker questTracker;

    public GameObject obj;
    public string journalEntry;
    public bool newObj;

    private void Start()
    {
        triggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(player) && !triggered)
        {
            // This is where the play audio command would come in
            Debug.Log("Narration: \"" + dialogue + "\"");
            triggered = true;

            // Set subtitles
            m_canvas.GetComponent<Subtitles>().setText("[Narrator] : " + dialogue);

            if(newObj)
            {
                questTracker.newObjective(obj.transform.position, "Journal: \n" + journalEntry);
            }
        }
    }
}
