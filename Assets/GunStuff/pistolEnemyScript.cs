using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolEnemyScript : MonoBehaviour
{
    public GameObject bullet;
    //public GameObject gun;
    public float shootTime = 3.3f;
    // Start is called before the first frame update
    void Start()
    {
        //start shooting at first frame
        StartCoroutine(Shoot());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnBullet()
    {
        //  instantiate bullet
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    IEnumerator Shoot()
    {
        //keep shooting until death of enemy
        while (true)
        {
            yield return new WaitForSeconds(shootTime);
            spawnBullet();
        }
    }
}
