using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaxingBallScript : MonoBehaviour {
    public static Vector3 velocity = Vector3.zero;
    
    Vector2 myDimensions = new Vector2(0.3351483f * 2, 0.3351483f * 2);
    public static int speed = 4;


    // Start is called before the first frame update
    void Start()
    {
        velocity = (-Vector3.right + Vector3.up) * speed;
    }

    // Update is called once per frame
    void Update() {
        Vector3 worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));


        transform.position += velocity * Time.deltaTime;

        if(transform.position.y > Camera.main.transform.position.y + worldDim.y){
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }
        if(transform.position.y < Camera.main.transform.position.y - worldDim.y){
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }
        if(transform.position.x > Camera.main.transform.position.x + worldDim.x){
            velocity = new Vector3(-velocity.x, velocity.y, 0);

        }
        if(transform.position.x < Camera.main.transform.position.x - worldDim.x){
            velocity = new Vector3(-velocity.x, velocity.y, 0);

        }
    }
}