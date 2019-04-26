using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points2 : MonoBehaviour
{
    [SerializeField]
    private AudioSource Opening;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject Finder = GameObject.FindWithTag("Player");
            Finder.GetComponent<ScoreCounter>().PointsObject2();
            Opening.Play();
            Destroy(this.gameObject);
        }
    }
}
