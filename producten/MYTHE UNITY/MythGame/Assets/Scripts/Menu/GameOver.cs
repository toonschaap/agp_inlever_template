using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Button RestartButton, StopButton;


   
    void Start()
    {
        RestartButton.onClick.AddListener(StartOnClick);
        StopButton.onClick.AddListener(ExitOnClick);

    }

    void StartOnClick()
    {
        SceneManager.LoadScene("PlayerMovement");
    }

    void ExitOnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
