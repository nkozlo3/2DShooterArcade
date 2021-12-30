using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunRotate : MonoBehaviour
{
    Vector3 mousePos;
    public Transform player;
    Vector3 gunPos;
    float angle;
    // Update is called once per frame
    void Update()
    {
        //if someone is holding gun // aka null check
        if (transform.parent.tag != null)
        {
            //if parent is enemy then aim towards player
            if (transform.parent.CompareTag("Enemy"))
            {
                mousePos = player.transform.position;
                gunPos = transform.position;
                mousePos.x = mousePos.x - gunPos.x;
                mousePos.y = mousePos.y - gunPos.y;
                angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
                //transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
                if (player.transform.position.x < transform.position.x)
                {
                    transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -angle));
                }
                else
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
                }
            }
            else
            {
                //if parent is not enemy it is player // aim towards mouse
                mousePos = Input.mousePosition;
                gunPos = Camera.main.WorldToScreenPoint(transform.position);
                mousePos.x = mousePos.x - gunPos.x;
                mousePos.y = mousePos.y - gunPos.y;
                angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

                if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
                {
                    transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -angle));
                }
                else
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
                }
            }
        }
    }
}