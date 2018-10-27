using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform detectPlayer;
    public int health;
    public float speed;
    public float detectRangeX;
    public float detectRangeY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] playerDetect = Physics2D.OverlapBoxAll(detectPlayer.position, new Vector2(detectRangeX, detectRangeY), 0);
        transform.Translate(Vector2.left * speed * Time.deltaTime);
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

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(detectPlayer.position, new Vector3(detectRangeX, detectRangeY, 1));
    }
}
