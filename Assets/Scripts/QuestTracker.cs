using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTracker : MonoBehaviour
{
    public GameObject journalObj;
    [SerializeField] private Vector3 objective;
    [SerializeField] private string journalEntry;

    private void Start()
    {
        objective = this.transform.position;
        journalEntry = "";
    }

    private void Update()
    {
        this.transform.position = objective;
    }

    public void newObjective(Vector3 location, string journalEntry)
    {
        this.objective = location;
        this.journalEntry = journalEntry;

        journalObj.GetComponent<Text>().text = journalEntry;
    }
}
