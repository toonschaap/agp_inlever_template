using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private AudioSource hit;
    [SerializeField]
    private int Counter;
    [SerializeField]
    private AudioSource dealDamage;

    private void Update()
    {
        if (Counter <= 0)
        {
            GetComponent<EnemyAttack>().enabled = false;
            GetComponent<EnemyMovement>().enabled = false;
            StartCoroutine("EnemyDeathTimer");
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        //Changing the tag to a gameobject broke the script. Therefore the tags remained.
        if (collision.gameObject.tag == "PlayerWeapon")
        {
            dealDamage.Play();
            Debug.Log("Enemy hit");
            Counter--;
        }
    }

    private IEnumerator EnemyDeathTimer()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}