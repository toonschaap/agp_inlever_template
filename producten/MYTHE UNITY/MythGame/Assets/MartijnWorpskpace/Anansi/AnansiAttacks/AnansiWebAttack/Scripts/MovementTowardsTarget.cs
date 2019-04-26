using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTowardsTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private int speed;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
