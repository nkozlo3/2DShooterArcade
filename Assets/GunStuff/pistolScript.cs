using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolScript : MonoBehaviour
{
    bool fireRunning;
    public GameObject playerBullet;
    public static bool powerUpClaimed = false;
    bool getPowerUpClaimed;
    float shootTime;
    bool coroutineActive = false;

    // Update is called once per frame
    void Update()
    {
        //can't get powerup more than once
        getPowerUpClaimed = powerUpClaimed;

        // starting firing on pressing C
        if (Input.GetKeyDown(KeyCode.C) && fireRunning == false)
        {
            StartCoroutine(Fire());
        }
        //if powerupclaimed true then do nothing
        if (powerUpClaimed == true && coroutineActive == false)
        {

        }
        //changing shoot time based on powerup
        if (getPowerUpClaimed == false)
        {
            shootTime = .8f;
        }
        if (getPowerUpClaimed == true)
        {
            shootTime = .4f;
        }

    }
    IEnumerator Fire()
    {
        //can't start firing more than once at a time
        //instantiate bullet
        fireRunning = true;
        yield return new WaitForSeconds(shootTime);
        if (transform.parent.gameObject.CompareTag("Player"))
        {
            Instantiate(playerBullet, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("not holding gun");
        }
        fireRunning = false;
    }
   IEnumerator endPowerup()
    {
        // end powerup
        coroutineActive = true;
        yield return new WaitForSeconds(5f);
        getPowerUpClaimed = false;
        coroutineActive = false;

    }
}
