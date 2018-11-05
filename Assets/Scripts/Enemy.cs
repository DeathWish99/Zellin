using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    GameController gc;

    private Vector2 currDir;
    private RaycastHit2D hit;
    // Use this for initialization
    void Start()
    {
        currDir = Vector2.left;
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(transform.position, currDir);


        if (hit)
        {
            Debug.Log("Hit");
            if (hit.transform.gameObject.tag == "Player")
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                Debug.Log("HIT");
            }
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


    private void OnCollisionEnter2D(Collision2D collision)
>>>>>>> 73d6e0de7da263f773a359922fe9de77df9a2f0f
    {
        if(collision.gameObject.tag == "Player")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
<<<<<<< HEAD
            rb.AddForce(new Vector2(currDir.x * 450, 0));
            gc.TakeDamage(1);
=======
            rb.AddForce(new Vector2(currDir.x * 2050, 0));
            gc.TookDamage(1);
>>>>>>> 73d6e0de7da263f773a359922fe9de77df9a2f0f
            Debug.Log("Collide");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Took Damage");
    }
    
}
