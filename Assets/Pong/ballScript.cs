using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
    public static Vector3 velocity = Vector3.zero;
    
    Vector2 myDimensions = new Vector2(0.3351483f * 2, 0.3351483f * 2);

    public GameObject playerPaddle;
    public GameObject enemyPaddle;
    public GameObject speedPreFab;
    public int enemyScore = 0;
    public int playerScore = 0;
    public static int speed = 4;
    public static float mode = 0f;


    // Start is called before the first frame update
    void Start()
    {
        mode = MainMenu.whichClick;
        velocity = (-Vector3.right + Vector3.up) * speed;
        reset();
    }

    // Update is called once per frame
    void Update() {
        Vector3 worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (MainMenu.powerMode == false && mode != 5f && mode != 8f) {
        if (velocity.x < 12) {
        velocity *= 1.0001f;
        }
        }


        transform.position += velocity * Time.deltaTime;
        if(transform.position.y > Camera.main.transform.position.y + worldDim.y){
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }
        if(transform.position.y < Camera.main.transform.position.y - worldDim.y){
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }
        if(transform.position.x > Camera.main.transform.position.x + worldDim.x){
            playerScore++;
            reset();

        }
        if(transform.position.x < Camera.main.transform.position.x - worldDim.x){
            enemyScore++;
            reset();
        }

        //Collision against player paddle
        if(collision(new Vector2(0.5862308f, 2.666667f), playerPaddle.transform.position)){
            velocity = new Vector3(-velocity.x, velocity.y, 0);
            transform.position = new Vector3(playerPaddle.transform.position.x + 0.5862308f/2 + myDimensions.x/2, transform.position.y, 0);
            Debug.Log("Collided");
        }

        //Collision against enemy paddle
        if(collision(new Vector2(0.5862308f, 2.666667f), enemyPaddle.transform.position)){
            velocity = new Vector3(-velocity.x, velocity.y, 0);
            Debug.Log("Collided");
        }
    }

    bool collision(Vector2 dimensions, Vector3 colliderPos) {
        float xDist = colliderPos.x - transform.position.x;
        float yDist = colliderPos.y - transform.position.y;
        if(Mathf.Abs(xDist) < dimensions.x/2 + myDimensions.x/2 && Mathf.Abs(yDist) < dimensions.y/2 + myDimensions.y/2){
            return true;
        }
        else
        {
            return false;
        }
    }

    void reset(){
        transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
    }
}