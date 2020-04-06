using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public Animator animator;
    public Collider m_collider;

    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
        m_collider = this.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Attack") != 0)
        {
            m_collider.enabled = true;
            animator.SetBool("Attacking", true);
        }
        else
        {
            m_collider.enabled = false;
            animator.SetBool("Attacking", false);
        }
    }
}
