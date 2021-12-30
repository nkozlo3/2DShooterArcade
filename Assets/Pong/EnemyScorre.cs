using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScorre : MonoBehaviour {
    public Text myText;
    public GameObject ball;

    //MonoBehaviour ballCode
    // Start is called before the first frame update
    void Start() {

        //myText.text = value;
    }

    // Update is called once per frame
    void Update() {
        int value = ball.GetComponent<ballScript>().enemyScore;
        myText.text = value.ToString();
    }
}
