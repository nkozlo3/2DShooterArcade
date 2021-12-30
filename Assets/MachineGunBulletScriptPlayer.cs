using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunBulletScriptPlayer : MonoBehaviour
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
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.Self);
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(hitHere.position, range);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Box")
        {
            collision.GetComponent<boxDestruction>().hitByBullet();
            Destroy(gameObject);
        }
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().IfHit(damage);
            Destroy(gameObject);
        }
        if (collision.tag == "PlatformShootableThrough" || collision.tag == "Weapon" || collision.tag == "MG" || (collision.tag == "Player"))
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyAtTime()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
