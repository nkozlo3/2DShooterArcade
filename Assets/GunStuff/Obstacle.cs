using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SpawnObstacle()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(Time.deltaTime);
            float spawnY = Random.Range(-1, 3);
            float spawnX = Random.Range(-2, 3);

            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
            Vector3 camPos = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
            Instantiate(obstacle1, camPos + spawnPosition, Quaternion.AngleAxis(Random.Range(-30f, 30f), Vector3.forward));
        }
    }
}
