using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : MonoBehaviour
{
    public GameObject ball;
    float move;
    public float enemySpeed = 0f;

    Vector3 worldDim;
    float xPos;

    //Don't destroy enemySpeed between scenes to change difficulty
    // void Awake()
    // {
    //     DontDestroyOnLoad(enemySpeed);
    // }

    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = MainMenu.whichClick;
        worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        xPos = Camera.main.transform.position.x + worldDim.x/1.2f;
        transform.position = new Vector3(xPos, Camera.main.transform.position.y, 0);

    }

    // Update is called once per frame
    void Update()
    {
        move = Mathf.Sign(ball.transform.position.y - transform.position.y);
        transform.position += Vector3.up * Time.deltaTime * move * enemySpeed;
    }
}
