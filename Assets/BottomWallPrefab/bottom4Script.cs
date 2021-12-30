using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom4Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BottomWallT.amountTimesHit == 6) {
            Destroy(gameObject);
        }
        
    }
}
