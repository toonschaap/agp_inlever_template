using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    GameObject Bullet;
    public GameObject Projectile;
    public int firerate;
    
    // Start is called before the first frame update
    void Start()
    {

    }

   void Update()
    {
        StartCoroutine("WaitForShot");
    }

    IEnumerator WaitForShot()
    {
        yield return new WaitForSeconds(firerate);
        Bullet = Instantiate(Projectile, transform.position, Quaternion.identity) as GameObject;
        StopCoroutine("WaitForShot");
        
    }
}
