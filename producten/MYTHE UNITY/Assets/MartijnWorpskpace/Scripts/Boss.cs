using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private GameObject[] Objects;

    //The target player
    public Transform PlayerTransform;

    //At what distance will the enemy walk towards the player?
    public float walkingDistance = 100.0f;

    //In what time will the enemy complete the journey between its position and the players position
    public float smoothTime = 100.0f;

    //Vector3 used to store the velocity of the enemy
    private Vector3 smoothVelocity = Vector3.zero;

    //Call every frame
    private bool moveTo = true;

    private bool attack = false;

    public GameObject Player;

    public bool startCou;

    private float currCountdownValue;

    private void Update()
    {
        //Look at the player
        transform.LookAt(PlayerTransform);
        //Calculate distance between player
        float distance = Vector3.Distance(transform.position, PlayerTransform.position);
        //If the distance is smaller than the walkingDistance
        if (distance < walkingDistance && moveTo == true)
        {
            //Move the enemy towards the player with smoothdamp
            transform.position = Vector3.SmoothDamp(transform.position, PlayerTransform.position, ref smoothVelocity, smoothTime);
        }
        if (distance <= 10)
        {
            moveTo = false;
            StartCoroutine("CoroutineExample");
        }
        if (distance >= 10)
        {
            moveTo = true;
            StopCoroutine("CoroutineExample");
        }

        Attack1();
    }

    private void Attack1()
    {
        float distance = Vector3.Distance(transform.position, PlayerTransform.position);

        if (attack == true && distance <= 10)
        {
            Destroy(Player);
            Debug.Log("Hit");
            attack = false;
        }
    }

    private IEnumerator CoroutineExample()
    {
        yield return new WaitForSeconds(1);
        attack = true;
    }
}