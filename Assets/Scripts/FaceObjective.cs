using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObjective : MonoBehaviour
{
    public GameObject objective;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(objective.transform.position);
        this.transform.Rotate(90, 0, 0);
    }
}
