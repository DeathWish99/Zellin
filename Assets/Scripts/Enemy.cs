using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform detectPlayer;
    public int health;
    public float speed;

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
<<<<<<< HEAD
<<<<<<< HEAD
            gc.AddScore(100);
        }
    }


<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
=======
    private void OnCollisionStay2D(Collision2D collision)
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
    {
        if(collision.gameObject.tag == "Player")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
<<<<<<< HEAD
            rb.AddForce(new Vector2(currDir.x * 450, 0));
            gc.TakeDamage(1);
=======
            rb.AddForce(new Vector2(currDir.x * 50, 0));
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
            Debug.Log("Collide");
=======
>>>>>>> parent of ef52532... Update
=======
>>>>>>> parent of ef52532... Update
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Took Damage");
    }
    
}
