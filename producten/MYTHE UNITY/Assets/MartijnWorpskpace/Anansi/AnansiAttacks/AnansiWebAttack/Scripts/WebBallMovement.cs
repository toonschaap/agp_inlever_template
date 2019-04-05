using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebBallMovement : MonoBehaviour
{
    public GameObject Deflecttarget;
    Vector3 movement;
    public float DeflectMovement;

    public IEnumerator InverseMovement()
    {
        GetComponent<NormalWebMove>().enabled = false;
        float interpolate = 0;
        while(interpolate < 100)
        {
            transform.position = Vector3.MoveTowards(transform.position, Deflecttarget.transform.position, interpolate);
            interpolate += DeflectMovement * Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "EnemyHitBox" || collision.gameObject.tag == "PlayerHitBox")
        {
            
            Destroy(this.gameObject);
        }
    }

    
}