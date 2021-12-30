using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyScore : MonoBehaviour
{

   public GameObject left2;
   public GameObject left3;
   public GameObject left4;
   public GameObject left5;
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
            Instantiate(left2, transform.position, transform.rotation);
        }
        if (amountTimesHit == 2) {
            Instantiate(left3, transform.position, transform.rotation);
            // Delete(gameObject);
        }
        if (amountTimesHit > 3) {
            SceneManager.LoadScene(6);
        }
    }
}
