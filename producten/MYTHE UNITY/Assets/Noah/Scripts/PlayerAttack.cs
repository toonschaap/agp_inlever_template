using System.Collections;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool Attack;

    [HideInInspector]
    public Animator anim;

    [SerializeField]
    private float attackSpeed = 1f;

    private float nextAttack = 0.0f;

    [SerializeField]
    private BoxCollider Sword;

    public void Start()
    {
        Sword.enabled = false;
        anim.SetBool("Attack", Attack);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextAttack)
        {
            Attack = true;
            Sword.enabled = true;
            nextAttack = Time.time + attackSpeed;
        }
        else
        {
            Attack = false;
            Sword.enabled = false;
        }
    }
}