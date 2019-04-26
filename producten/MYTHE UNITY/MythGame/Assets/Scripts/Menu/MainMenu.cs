using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Button StartButton, ExitButton;


  
    void Start()
    {
        StartButton.onClick.AddListener(StartOnClick);
      
        
    }


    void StartOnClick()
    {
        SceneManager.LoadScene("PlayerMovement");
    }


}
