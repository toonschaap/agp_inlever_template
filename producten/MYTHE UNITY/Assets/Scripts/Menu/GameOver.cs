using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Button RestartButton, StopButton;


    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(StartOnClick);
        StopButton.onClick.AddListener(ExitOnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartOnClick()
    {
        SceneManager.LoadScene("Menu");
    }

    void ExitOnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
