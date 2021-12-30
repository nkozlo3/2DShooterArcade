using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingPlayer : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public float speed = 0.009f;
    public int damage = 1;
    public float range;
    public Transform hitHere;
    public LayerMask playerLayer;
    public float destroyTime = 7f;
    // Start is called before the first frame update
    private void Awake()
    {
        // starting destruction of bullet
        StartCoroutine(DestroyAtTime());
    }

    // Update is called once per frame
    void Update()
    {
        //speed of bullet
            velocity.x += speed;
            transform.position += velocity * Time.deltaTime;

    }
    void OnDrawGizmos()
    {
        //collision space for bullet editing in unity
        Gizmos.DrawWireSphere(hitHere.position, range);
    }
    //if collides with another object
    void OnTriggerEnter2D(Collider2D collision)
    {



        //box destruction
        if (collision.tag == "Box" && collision != null)
        {
            collision.GetComponent<boxDestruction>().hitByBullet();
            Destroy(gameObject);
        }
        //enemy damage class called
        if (collision.tag == "Enemy" && collision != null)
        {
            Debug.Log("collided" + "with" + collision.name);
            collision.GetComponent<Enemy>().IfHit(damage);
            Destroy(gameObject);
        } 
        //destroy bullet on contact
        if (collision.tag != "Player" && collision.tag != "Pistol")
        {
            Destroy(gameObject);

        }
    }

    //return an amount of seconds then destroys game object
    //called on awake (before first frame)
    IEnumerator DestroyAtTime()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
