using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Button StartButton, ExitButton;


    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartOnClick);
       // ExitButton.onClick.AddListener(ExitOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartOnClick()
    {
        SceneManager.LoadScene("PlayerMovement");
    }

 //   void ExitOnClick()
  //  {
   //     UnityEditor.EditorApplication.isPlaying = false;
  //  }


}
