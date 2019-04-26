using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Animator animator;
    private GameObject player;
    private bool collidedWithPlayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    //trigger enter
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            animator.SetBool("attackRange", true);
        }
    }

    //trigger exit
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            animator.SetBool("attackRange", false);
        }
    }
}