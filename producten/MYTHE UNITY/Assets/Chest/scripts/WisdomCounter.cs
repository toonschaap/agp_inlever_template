using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WisdomCounter : MonoBehaviour
{
    

    [SerializeField]
    public int Wisdom;
    public Text WisdomText;

    // Start is called before the first frame update
    void Start()
    {
        Wisdom = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Counter();
        
    }

    void Counter()
    {
        WisdomText.text = "Wisdom = " + Wisdom;
    }

   public void IncreaseWisdomChest()
    {
        Wisdom = Wisdom += 10;
    }

}
