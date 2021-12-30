using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpeedPowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pistolScript.powerUpClaimed = true;
            Debug.Log(pistolScript.powerUpClaimed);
            Destroy(gameObject);
        }
    }
}
