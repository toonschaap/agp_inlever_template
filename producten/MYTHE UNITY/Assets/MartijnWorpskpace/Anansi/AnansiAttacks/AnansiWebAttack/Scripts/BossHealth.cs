using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public int BossHp;

    // Start is called before the first frame update
    void Start()
    {
        BossHp = 3;    
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHp == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void OnCollisionEnter(Collision collision)//Damage to boss when web is deflected
    {
        if (collision.gameObject.tag == "projectile")
        {
            BossHp = BossHp --;
            Debug.Log("Boss has taken damage");
        }
        
    }
}
