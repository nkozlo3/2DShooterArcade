using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunScriptPlayer : MonoBehaviour
{
    public GameObject machineGunBullet;
    public static bool playerGunShooting = false;
    public Transform shootFromHere;
    public Transform player;
    float distanceBetweenPlayer;
    bool fireRunning = false;
    public Transform setHoldingGun;
    public static Transform holdingGun;

    void Awake()
    {
        playerGunShooting = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        //setting if enemy or player has gun 
        holdingGun = setHoldingGun;

    }

    // Update is called once per frame
    void Update()
    {
        //if press C start firing
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(Fire());
        }
        else
        {
            StopCoroutine(Fire());
        }

    }
    IEnumerator Fire()
    {
        // letting script know gun is firing
        fireRunning = true;
        while (Input.GetKey(KeyCode.C))
        {
            //wait .5S then shoot new bullet
            yield return new WaitForSeconds(.5f);
            Instantiate(machineGunBullet, shootFromHere.transform.position, shootFromHere.transform.rotation);
        }
        fireRunning = false;
    }
}
