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
        
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(currDir.x * 450, 0));
            gc.TakeDamage(1);
            Debug.Log("Collide");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Took Damage");
    }
    
}
