using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSounds : MonoBehaviour
{

    public AudioSource walk;
    public AudioSource run;

    private bool isWalking = true;

    // Update is called once per frame
    void Update()
    {
        bool shift = Input.GetKeyDown(KeyCode.LeftShift);
        bool keys = Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d");

        if (keys)
        {
            {
                walk.Play();
                walk.loop = true;
            }
        }

        if (Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d") || shift)
        {
            isWalking = false;
            walk.Stop();
        }

        if (shift && Input.GetKey("w") || shift && Input.GetKey("s") || shift && Input.GetKey("a") || shift && Input.GetKey("d"))
        {
            isWalking = false;

            run.Play();
            run.loop = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            walk.Play();
            walk.loop = true;
            run.Stop();
            isWalking = true;
        }
    }
}
