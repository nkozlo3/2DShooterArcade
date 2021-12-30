using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunTowardsPlayer : MonoBehaviour
{
    public Transform player;
    public float speed;
    float distanceBetweenPlayer;
    public float meleeDamage;
    float currentTime;
    bool collided = false;
    // Update is called once per frame
    void Update()
    {
        //character reset melee attack on contact
        if (collided == true)
        {
            if (Time.time - currentTime >= .2f)
            {
                collided = false;
            }
        }
        //when to start chasing player 
        // if attacked or if close enough
        distanceBetweenPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceBetweenPlayer <= 9f || gameObject.GetComponent<Enemy>().health < 5)
        {
            //follow mechanics
            if (player.transform.position.x < transform.position.x)
            {
                if (collided == false)
                    transform.position += Vector3.left * Time.deltaTime * speed;
                if (collided == true)
                    transform.position += Vector3.right * Time.deltaTime * speed;
            } else
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
            }
        }
    }
    //activate player and box damageClasses on collision with them
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collided = true;
            collision.collider.GetComponent<CharacterOne>().ifDamaged(meleeDamage);
            currentTime = Time.time;
        }
        if (collision.collider.tag == "Box")
        {
            collision.collider.GetComponent<boxDestruction>().hitByMelee();
        }
    }
}
