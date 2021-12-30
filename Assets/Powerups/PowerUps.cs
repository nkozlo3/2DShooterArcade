using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    public static int ballSpeedIncrease = 2;
    Vector3 worldDim;
    float xPos;
    float destroyTime = 8f;
    // Start is called before the first frame update

    void Awake() {
        if (MainMenu.powerMode == false) {
            Destroy(this);
        }
        StartCoroutine(DestroyAfterTime());
    }

    void Start()
    {
        worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        xPos = Camera.main.transform.position.x - worldDim.x/1.25f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPos, PaddlePlayer.mousePos.y, 0);
    }
    IEnumerator DestroyAfterTime(){
    yield return new WaitForSeconds(destroyTime);
     Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ball") {
            ballScript.velocity *= 1.2f;
            Destroy(gameObject);
        }
    }
}
