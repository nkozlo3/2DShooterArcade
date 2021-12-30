using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Update()
    {

        //make camera follow player

        transform.position = new Vector3(player.transform.position.x + 8, transform.position.y, transform.position.z);


    }
}
