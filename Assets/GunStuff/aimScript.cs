using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimScript : MonoBehaviour
{
    Transform aimHere;
    public static Vector3 mousePos;
    //public Transform aim;
    public Vector3 objectPos;
    float angle;

    // Update is called once per frame
    void Update()
    {
        //rotate gun based on mouse position
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }
    }

    
}
