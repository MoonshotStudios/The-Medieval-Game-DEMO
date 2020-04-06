using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killable : MonoBehaviour
{
    public GameObject sword;
    [SerializeField] private int health;
    public Collider m_collider;
    public Animator animator;
    [SerializeField] private bool dead;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        dead = false;
    }

    private void Update()
    {
        if(dead)
        {
            animator.SetBool("Dying", false);
        }
        if(health <= 0)
        {
            animator.SetBool("Dying", true);
            dead = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(sword)) // Ensure that the sword is what hit it
        {
            Debug.Log("Hit on " + this.gameObject.name);
            health--; // Lower the health by 1 (the sword does 1 damage for now)
        }
    }
}
