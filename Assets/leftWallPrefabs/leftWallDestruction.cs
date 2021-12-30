using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftWallDestruction : MonoBehaviour
{

    GameObject left2;
    int amountTimesHit = 0;

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Enter?");
        if (other.gameObject.tag == "Ball") {
            amountTimesHit++;
        }
    }
    void update() {
        if (amountTimesHit == 1) {
            Instantiate(left2, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
