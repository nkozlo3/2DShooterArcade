using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject blood;
    public GameObject gunn;
    //public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
     
        //death if health less than or equal to 0
        if (health <= 0)
        {
            PortalScript.numEnemies--;
            Destroy(gameObject);
        }
    }
    //referenced by other gameObjects to damage enemy
    public void IfHit(int damage)
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        health -= damage;
    }
}
