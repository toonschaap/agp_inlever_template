using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   [SerializeField]
   private GameObject MenuList;

   [SerializeField]
   private Button ContinueButton, SettingsButton, StopButton;

    private int menuInt; 

    // Start is called before the first frame update
    void Start()
    {
        ContinueButton.onClick.AddListener(ContinueOnClick);
        SettingsButton.onClick.AddListener(SettingsOnClick);
        StopButton.onClick.AddListener(StopOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuList.SetActive(true);
            menuInt++;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        if (menuInt == 2)
        {
            MenuList.SetActive(false);
            menuInt = 0;
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void ContinueOnClick()
    {
        MenuList.SetActive(false);
        menuInt = 0;
        Time.timeScale = 1;
    }

    void SettingsOnClick()
    {
        Debug.Log("Settings");
    }

    void StopOnClick()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

}
