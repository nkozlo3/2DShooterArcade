using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineGunScript : MonoBehaviour
{
    public GameObject machineGunBullet;
    public Transform shootFromHere;
    public Transform player;
    float distanceBetweenPlayer;
    bool fireRunning = false;
    public Transform setHoldingGun;
    public static Transform holdingGun;
    // Start is called before the first frame update
    void Start()
    {
        holdingGun = setHoldingGun;

    }

    // Update is called once per frame
    void Update()
    {

        //enemy starts shooting MG at this distance from player
        distanceBetweenPlayer = Vector3.Distance(transform.position, player.position);
        if (transform.parent.tag == "Enemy" && fireRunning == false && distanceBetweenPlayer <= 9f)
        {
            StartCoroutine(Fire());

        }

    }
    IEnumerator Fire()
    {
        //instantiation of bullet and bullet trajectory
        fireRunning = true;
        if (transform.parent.tag == "Enemy")
        {
            while (distanceBetweenPlayer <= 9f)
            {
                yield return new WaitForSeconds(.5f);
                Instantiate(machineGunBullet, shootFromHere.transform.position, shootFromHere.transform.rotation);
            }
        }
        fireRunning = false;
    }
}
