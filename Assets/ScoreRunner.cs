using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro.EditorUtilities
{
    public class ScoreRunner : MonoBehaviour
    {
        public TMP_Text myText;
        public GameObject ball;
        float startTime;

        //MonoBehaviour ballCode
        // Start is called before the first frame update
        void Start()
        {
            startTime = Time.time - Time.time;

            //myText.text = value;
        }

        // Update is called once per frame
        void Update()
        {
            startTime += Time.deltaTime;
            //int value = ball.GetComponent<ballScript>().playerScore;
            myText.text = startTime.ToString();
        }
    }
}
