using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSword : MonoBehaviour
{
    [SerializeField] private float rotSpeed;
    public GameObject sword;

    private void Start()
    {
        rotSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        sword.transform.Rotate(Vector3.up * rotSpeed);
    }
}
