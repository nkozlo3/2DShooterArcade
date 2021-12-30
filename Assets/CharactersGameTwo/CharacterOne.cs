using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterOne : MonoBehaviour
{
    public static float speed = 4f;
    public static float jump = 5f;
    Rigidbody2D RG;
    Vector3 worldDim;
    public static Vector3 movement;
    public Animator anim;
    public float health = 10;
    public Transform attackHere;
    public float range = 0.5f;
    public LayerMask enemyLayers;
    public int damage = 1;
    public GameObject blood;
    public float destroyTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //recording width of screen to position player and creating rigidBody
        worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        RG = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //death
        if (health <= 0)
        {
            Die();
        }
        //movement using left and right arrows
        movement.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moving", Mathf.Abs(movement.x));
        transform.position += new Vector3(movement.x, 0, 0) * Time.deltaTime * speed;    
        //jump movement on spacebar press 
        //adding force to the rigidBody using ForceMode2D
        if (Input.GetButtonDown("Jump")) {
            anim.SetBool("Jumping", true);
            RG.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
        if (RG.position.y < -3.5)
        {
            anim.SetBool("Jumping", false);
        }
        //start attack function if press V
         if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Pressed V");
            swing();

        }
    }

    void swing()
    {
        //start attack animation
        anim.SetTrigger("Attacking");
        //attack all enemies in Collider2D
        Collider2D[] atcEnemy = Physics2D.OverlapCircleAll(attackHere.position, range, enemyLayers);
        foreach (Collider2D enemy in atcEnemy)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<Enemy>().IfHit(damage);
        }
    }

    //death animation and start DestroyAfterTime to destroy gameObject
    void Die()
    {
        anim.SetTrigger("Dead");
        this.enabled = false;
        StartCoroutine(DestroyAfterTime());

    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackHere.position, range);
    }

    //instantiate blood and kill character if health low enough upon damage
    public void ifDamaged(float damageToMe)
    {
        health -= damageToMe;
        Instantiate(blood, transform.position, Quaternion.identity);
        if (health <= 0)
        {
            Die();
        }
    }
    //destroy game object and load character selection screen after animation ends
    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(destroyTime);
        SceneManager.LoadScene(6);
        Destroy(gameObject);
    }
}
