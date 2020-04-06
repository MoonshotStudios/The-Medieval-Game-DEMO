using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnEnter : MonoBehaviour
{
    public GameObject player;
    public GameObject thisObject;
    public GameObject handheldSword;
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(player))
        {
            handheldSword.SetActive(true);
            Debug.Log("The sword has been picked up.");
            thisObject.SetActive(false);
        }
    }
}
