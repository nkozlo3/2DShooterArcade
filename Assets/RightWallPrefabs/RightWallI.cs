using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightWallI : MonoBehaviour
{
   public GameObject right2;
   public GameObject right3;
   public GameObject right4;
   public GameObject right5;
   public static int amountTimesHit = 0;
    void update() {
    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(amountTimesHit);
        Debug.Log("here in left wall script");
        if (other.gameObject.tag == "Ball") {
            amountTimesHit++;
        }
        if (amountTimesHit == 1) {
            Instantiate(right2, transform.position, transform.rotation);
        }
        if (amountTimesHit == 2) {
            Instantiate(right3, transform.position, transform.rotation);
            // Delete(gameObject);
        }
        if (amountTimesHit > 3) {
            SceneManager.LoadScene(6);
        }
    }
}
