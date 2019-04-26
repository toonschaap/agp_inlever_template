using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectedMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject Deflecttarget;
    Vector3 movement;
    [SerializeField]
    private float DeflectMovement;
    [SerializeField]
    private GameObject Hitbox1;
    [SerializeField]
    private GameObject Hitbox2;
    [SerializeField]
    private int Distance;


    public IEnumerator InverseMovement()
    {
        GetComponent<MovementTowardsTarget>().enabled = false;
        float interpolate = 0;
        while(interpolate < Distance)
        {
            transform.position = Vector3.MoveTowards(transform.position, Deflecttarget.transform.position, interpolate);
            interpolate += DeflectMovement * Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == Hitbox1 || collision.gameObject == Hitbox2)
        {
            
            Destroy(this.gameObject);
        }
    }

    
}