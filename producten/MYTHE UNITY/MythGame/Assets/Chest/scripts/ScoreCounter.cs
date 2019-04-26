using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private int Score;
    [SerializeField]
    private Text ScoreText;
    [SerializeField]
    private int Score1;
    [SerializeField]
    private int Score2;
    [SerializeField]
    private int Score3;

    private void FixedUpdate()
    {
        ScoreText.text = "Wisdom = " + Score;
    }
    /*I wanted to put all these functions into one large OnCollisionEnter.
      Unfortunatly I had issues with destroying the gameObjects after Collision was made.
      Which is why I kept it the way it is.-Toon
    */
    public void PointsObject1()
    {
        Score = Score += Score1;
    }

   public void PointsObject2()
    {
        Score = Score += Score2;
    }

    public void PointsObject3()
    {
        Score = Score += Score3;
    }



}
