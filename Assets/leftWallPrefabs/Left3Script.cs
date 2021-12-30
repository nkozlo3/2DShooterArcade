using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left3Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyScore.amountTimesHit == 4) {
            Destroy(gameObject);
        }
        
    }
}
