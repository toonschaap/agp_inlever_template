using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardChestOpening : MonoBehaviour
{
    public int WisdomInChest;
    public bool ChestOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GiveWisdom();
            StartCoroutine("ChestAnimation");
 
        }
    }

    void GiveWisdom()
    {
        GameObject Finder = GameObject.FindWithTag("Player");
        Finder.GetComponent<WisdomCounter>().IncreaseWisdomChest();
        
    }

    IEnumerator ChestAnimation()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        //Play animation
    }
}
