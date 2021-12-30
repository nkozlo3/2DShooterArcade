using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro.EditorUtilities{
public class BoardPlayerScore : MonoBehaviour {
    public TMP_Text myText;
    public GameObject ball;

    //MonoBehaviour ballCode
    // Start is called before the first frame update
    void Start() {

        //myText.text = value;
    }

    // Update is called once per frame
    void Update() {
        int value = ball.GetComponent<ballScript>().playerScore;
        myText.text = value.ToString();
    }
}
}
