using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWallT : MonoBehaviour
{
   public GameObject bottom2;
   public GameObject bottom3;
   public GameObject bottom4;
   public GameObject bottom5;
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
            Instantiate(bottom2, transform.position, transform.rotation);
        }
        if (amountTimesHit == 2) {
            Instantiate(bottom3, transform.position, transform.rotation);
            // Delete(gameObject);
        }
        if (amountTimesHit > 3) {
            SceneManager.LoadScene(6);
        }
    }
}
