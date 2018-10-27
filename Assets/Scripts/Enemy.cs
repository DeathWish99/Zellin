using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform detectPlayer;
    public int health;
    public float speed;
    private int counter = 1; 


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
        /*
        Collider2D[] playerDetect = Physics2D.OverlapBoxAll(detectPlayer.position, new Vector2(detectRangeX, detectRangeY), 0);
        for (int i = 0; i < playerDetect.Length; i++) {
            if()
        }
        */

        hit = Physics2D.Raycast(transform.position, currDir);

        /*if (counter == 0) {
            currDir = Vector2.right;
            counter = 1;
        } else if(counter == 1) {
            currDir = Vector2.up;
            counter = 2;
        }
        else if (counter == 2)
        {
            currDir = Vector2.left;
            counter = 3;
        }
        else if (counter == 3)
        {
            currDir = Vector2.down;
            counter = 0;
        }*/


        if (hit)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            Debug.Log("HIT");
        }

       
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Took Damage");
    }
    
}
