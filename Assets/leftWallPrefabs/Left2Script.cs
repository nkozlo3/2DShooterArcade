using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left2Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyScore.amountTimesHit == 2) {
            Destroy(gameObject);
        }
        
    }
}
