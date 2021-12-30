using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public static int numEnemies;
    float distanceFromPlayer;
    public Transform player;
    public GameObject activePortal;
    bool portalAlreadyActive = false;
    // Start is called before the first frame update
    void Start()
    {
        // checking scene so I can assign number of enemies to kill until portal will activate
        Scene currentLevel = SceneManager.GetActiveScene();
        string nameOfLevel = currentLevel.name;
        Debug.Log(nameOfLevel);
        if (nameOfLevel == "Game Two")
        {
            numEnemies = 4;
        }
        if (nameOfLevel == "GameTwoLevel2")
        {
            numEnemies = 5;
        }
        //checking distance from player 
        StartCoroutine(DistanceOfPlayer());
    }

    // Update is called once per frame
    void Update()
    {
        // distance from player if close enough start portal
        distanceFromPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceFromPlayer <= 4f && numEnemies <= 0 && portalAlreadyActive == false)
        {
            StartPortal();
        }
    }
    void StartPortal()
    {
        //change portal to be active
        //active portal will change scenes
        portalAlreadyActive = true;
        Instantiate(activePortal, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //used for debugging purposes
    IEnumerator DistanceOfPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
        }
    }
}
