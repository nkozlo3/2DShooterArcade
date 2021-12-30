using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer : MonoBehaviour
{
    Vector3 worldDim;
    float xPos;
    public static Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        xPos = Camera.main.transform.position.x - worldDim.x/1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(xPos, mousePos.y, 0);
        
    }
}