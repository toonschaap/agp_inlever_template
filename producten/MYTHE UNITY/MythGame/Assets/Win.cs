using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("win");

        }
    }
}