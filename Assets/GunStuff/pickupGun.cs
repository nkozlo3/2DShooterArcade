using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupGun : MonoBehaviour
{
    //pickup gun if enemy drops
    bool hasGun = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        //pickup MG collides with player and does not already have gun
        if (collision.tag == "MG" && hasGun == false)
        {
            hasGun = true;
            collision.transform.parent = transform;
        }
        //pickup pistol collides with player and does not already have gun
        if (collision.tag == "Pistol" && hasGun == false)
        {
            hasGun = true;
            collision.transform.parent = transform;
        }
    }
}
