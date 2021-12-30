using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxDestruction : MonoBehaviour
{
    //box health
    public int boxHealth = 2;

    //referenced through other game objects
    public void hitByBullet()
    {
        boxHealth--;
        if (boxHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    //referenced through other gameObjects
    public void hitByMelee()
    {
        Destroy(gameObject);
    }
}
