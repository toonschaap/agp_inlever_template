using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    GameObject Bullet;
    [SerializeField]
    private GameObject Projectile;
    [SerializeField]
    private int firerate;
    [HideInInspector]
    public Animator anim;
    private bool WebAttack;
    [SerializeField]
    private ParticleSystem webAttack;
    private bool canShoot = true;
    [SerializeField]
    private AudioSource shootSound;
    [SerializeField]
    private GameObject activeModel;
    // Start is called before the first frame update
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


    private void HandleAttackAnimations()
    {

        anim.SetBool("WebAttack", WebAttack);
    }


    void FixedUpdate()
    {
        HandleAttackAnimations();

        if (canShoot)
        {
            canShoot = false;
            StartCoroutine("WaitForShot");
        }

    }

    IEnumerator WaitForShot()
    {
        WebAttack = true;
        yield return new WaitForSeconds(firerate);
        canShoot = true;
        WebAttack = false;

        Explode();
        Bullet = Instantiate(Projectile, transform.position, Quaternion.identity) as GameObject;
    }
    void Explode()
    {
        Instantiate(webAttack);
        webAttack.Play();
    }
}
