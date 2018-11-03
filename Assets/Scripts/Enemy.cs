using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    [SerializeField]private int rayRange = 20;
    public GameController gc;

    private bool hasFoundPlayer = false;
    private float dirTimer;
    private float dirTime;
    private int targetLayer;
    private Vector2 currDir;
    private RaycastHit2D hit;
    // Use this for initialization
    void Start()
    {
        dirTime = 1.0f;
        dirTimer = dirTime;
        currDir = Vector2.left;
        targetLayer = LayerMask.GetMask("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasFoundPlayer)
        {
            if (dirTimer > 0)
            {
                dirTimer -= Time.deltaTime;
            }
            else
            {
                currDir *= -1;
                dirTimer = dirTime;
                Debug.Log(currDir);
            }
        }
        

        hit = Physics2D.Raycast(transform.position, currDir, rayRange, targetLayer);
        

        if (hit)
        {
            hasFoundPlayer = true;
            if (hit.transform.gameObject.tag == "Player")
            {
                transform.Translate(currDir * speed * Time.deltaTime);
            }
        }
        else
        {
            hasFoundPlayer = false;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            gc.AddScore(100);
        }
    }


<<<<<<< HEAD
    private void OnCollisionStay2D(Collision2D collision)
=======
<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
=======
    private void OnCollisionStay2D(Collision2D collision)
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
>>>>>>> parent of 515238d... Revert "Merge branch 'master' of https://github.com/DeathWish99/Zellin"
    {
        if(collision.gameObject.tag == "Player")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
<<<<<<< HEAD
            rb.AddForce(new Vector2(currDir.x * 50, 0));
=======
<<<<<<< HEAD
            rb.AddForce(new Vector2(currDir.x * 450, 0));
            gc.TakeDamage(1);
=======
            rb.AddForce(new Vector2(currDir.x * 50, 0));
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
>>>>>>> parent of 515238d... Revert "Merge branch 'master' of https://github.com/DeathWish99/Zellin"
            Debug.Log("Collide");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Took Damage");
    }
    
}
