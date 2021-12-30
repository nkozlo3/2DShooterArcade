using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunnerScript : MonoBehaviour
{
    public static float movementUpDown;
    public float movementLeftRight;
    public GameObject blood;
    Rigidbody2D RG;
    float speed = 4f;
    public Animator anim;
    int health = 30;
    // Start is called before the first frame update
    void Start()
    {
        RG = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        movementUpDown = Input.GetAxisRaw("Vertical");
        movementLeftRight = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = 12f;

        }
        else
        {
            speed = 4f;
        }
        RG.velocity = new Vector2(movementLeftRight, movementUpDown) * speed;
        
    }

    public void IfHit(int damage)
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        health -= damage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            IfHit(1);
        }
    }
}
