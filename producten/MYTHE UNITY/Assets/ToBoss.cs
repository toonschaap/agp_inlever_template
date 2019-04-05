using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBoss : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("BoosRoom");

        }
    }
}

