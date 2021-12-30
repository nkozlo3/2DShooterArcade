using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public float speed = 0.009f;
    public float damage = 1f;
    public float destroyTime = 7f;
    public float range;
    public Transform hitHere;
    public LayerMask playerLayer;
    // Start is called before the first frame update

    private void Awake()
    {
        //starting destruction of bullet
        StartCoroutine(DestroyAtTime());
    }

    // Update is called once per frame
    void Update()
    {
        //setting speed and direction of bullet
        velocity.x += -speed;
        transform.position += velocity * Time.deltaTime;
        
    }
    void OnDrawGizmos()
    {
        //drawing sphere to edit bullet collider in unity
        Gizmos.DrawWireSphere(hitHere.position, range);
    }

    //on collision
    void OnTriggerEnter2D(Collider2D collision)
    {
        //starting box destruction // destroying bullet
        if (collision.tag == "Box" && collision != null)
        {

            collision.GetComponent<boxDestruction>().hitByBullet();
            Destroy(gameObject);
        }
        //starting player damage class // destroy bullet
        if (collision.tag == "Player" && collision != null)
        {
            Debug.Log("collided" + "with" + collision.name);
            collision.GetComponent<CharacterOne>().ifDamaged(damage);
            Destroy(gameObject);
        }
        if (collision.tag != "Enemy" && collision != null && collision.tag != "Weapon" && collision.tag != "MG" && collision.tag != "Pistol")
            Destroy(gameObject);
    }


    //destruction of bullet after destroyTime in seconds
    IEnumerator DestroyAtTime()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
