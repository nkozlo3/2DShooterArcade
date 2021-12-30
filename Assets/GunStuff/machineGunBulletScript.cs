using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineGunBulletScript : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 1;
    public float range;
    public Transform hitHere;
    public LayerMask playerLayer;
    public float destroyTime = 7f;

    private void Awake()
    {
        //start destroy bullet process on awake
        StartCoroutine(DestroyAtTime());
    }

    // Update is called once per frame
    void Update()
    {
        //speed and direction of bullet per frame
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.Self);
    }
    void OnDrawGizmos()
    {
        //for editing collision size of bullet
        Gizmos.DrawWireSphere(hitHere.position, range);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //destruction of bullet and interactions with other players
        if (collision.tag == "Box")
        {
            collision.GetComponent<boxDestruction>().hitByBullet();
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            collision.GetComponent<CharacterOne>().ifDamaged(damage);
            Destroy(gameObject);
        }
        if (collision.tag == "PlatformShootableThrough" || collision.tag == "Weapon" || collision.tag == "MG" || (collision.tag == "Enemy"))
        {

        } else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyAtTime()
    {
        //destroy bullet
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
