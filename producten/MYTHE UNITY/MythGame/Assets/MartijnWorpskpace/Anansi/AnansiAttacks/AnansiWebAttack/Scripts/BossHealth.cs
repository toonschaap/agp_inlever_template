using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

    [SerializeField]
    private int Counter;
    [SerializeField]
    private AudioSource dealDamage;

    private void Update()
    {
        if (Counter <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        //Changing the tag to a gameobject broke the script. Therefore the tags remained.
        if (collision.gameObject.tag == "projectile")
        {

            Debug.Log("Enemy hit");
            Counter--;
        }
    }

}
