using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{

    public BoxCollider2D coll;
    public Rigidbody2D rb;
    float widthScreen;
    float speed = -2f;
    //public GameObject obstacle1;
    //public GameObject obstacle2;
    //public GameObject obstacle3;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        widthScreen = coll.size.x;


        rb.velocity = new Vector2(speed, 0);
        //SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < widthScreen)
        {
            Vector2 reset = new Vector2(widthScreen * 2f, 0);
            transform.position = (Vector2)transform.position + reset;
        }
    }
    //void SpawnObstacle()
    //{
    //   StartCoroutine(spawn());
    //}
    //IEnumerator spawn()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1.5f);
    //        Debug.Log(Time.deltaTime);
    //        float spawnY = Random.Range(-3, 3);
    //        float spawnX = Random.Range(-3, 3);

    //        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
    //        Instantiate(obstacle1, spawnPosition, Quaternion.identity);
    //    }
    //}
}
