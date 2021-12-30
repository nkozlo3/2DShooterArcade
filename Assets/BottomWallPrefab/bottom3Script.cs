using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom3Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BottomWallT.amountTimesHit == 4) {
            Destroy(gameObject);
        }
        
    }
}
