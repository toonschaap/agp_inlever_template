using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points3 : MonoBehaviour
{
    [SerializeField]
    private bool Open;
    [SerializeField]
    private AudioSource openingSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GiveWisdom();
            openingSound.Play();
            StartCoroutine("ChestAnimation");

        }
    }

    void GiveWisdom()
    {
        GameObject Finder = GameObject.FindWithTag("Player");
        Finder.GetComponent<ScoreCounter>().PointsObject3();

    }

    IEnumerator ChestAnimation()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        //Play animation
    }

}
