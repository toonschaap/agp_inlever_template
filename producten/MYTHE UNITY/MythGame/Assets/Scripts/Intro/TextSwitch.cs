
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextSwitch : MonoBehaviour
{
    [SerializeField]
    private Text text;
    int TextInt = 0;

    void Awake()
    {
       
    }

    void Update()
    {
        ChangeText();

    }

    private void ChangeText()
    {
        // Press the space key to change the Text message.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TextInt++;
       
            if (TextInt == 1)
            {
                text.text = "Every year, our animals are taken from us, never to be seen again.";
            }
            else if (TextInt == 2)
            {
                text.text = "And every year, warriors go into the caves to find who’s behind this.";
            }
            else if (TextInt == 3)
            {
                text.text = "But the one behind this is no ordinary man.";
            }
            else if (TextInt == 4)
            {
                text.text = "He’s a being that will not rest until he has all the wisdom in the world.";
            }
            else if (TextInt == 5)
            {
                text.text = "His name is Anansi.";
            }
            else if (TextInt == 6)
            {
                SceneManager.LoadScene("MainMenu");
            }


        }
    }
}

