using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject Object;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float spawnThreshold = 100f;
    private float spawnTimer;


    [HideInInspector]
    public Animator anim;

    public GameObject activeModel;

    private bool Attack = false;




    private void Start()
    {
        SetupAnimator();
    }


    private void SetupAnimator()
    {
        if (activeModel == null)
        {
            anim = activeModel.GetComponent<Animator>();
            if (anim == null)
            {
                Debug.Log("no model found");
            }
            else
            {
                activeModel = anim.gameObject;
            }
        }

        anim = activeModel.GetComponent<Animator>();
    }
    private void HandleMovementAnimations()
    {
        anim.SetBool("RockAttack", Attack);
    }





    private void Update()
    {
        HandleMovementAnimations();



        StartCoroutine("StartSlamAnimation");


        spawnTimer += 0.01f;
        if (Attack)
        {
            if (spawnTimer >= spawnThreshold)
            {
                SlamAttackFunction();
                spawnTimer = 0;
            }
        }

    }

    private void SlamAttackFunction()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 playerDirection = player.transform.up;
        float height = 40;

        Vector3 spawnPos = playerPos + playerDirection * height;

        Instantiate(Object, spawnPos, Quaternion.identity);
        StopCoroutine("StartSlamAnimation");
        StartCoroutine("StartSlam");


    }

    IEnumerator StartSlamAnimation()
    {

        yield return new WaitForSeconds(5);
        Attack = true;
    }

    IEnumerator StartSlam()
    {

        yield return new WaitForSeconds(5);
        Attack = false;

    }


}
