using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10.0f;
    public float jumpForce = 1.0f;
    public float doubleJumpCooldown = 0.1f;
    private float doubleJumpCounter = 0.0f;
    private bool isOnGround = true;
    private bool isDoubleJumping = false;
    //private Animator anim;
    private Rigidbody2D rb;

    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(translation, 0, 0);

        if (translation < 0)
        {
            transform.localScale = new Vector3(-22, 21, 1);
        }
        else
        {
            transform.localScale = new Vector3(22, 21, 1);
        }

        //if (translation != 0)
        //{
        //    anim.SetFloat("Player Speed", speed);
        //}
        //else
        //{
        //    anim.SetFloat("Player Speed", 0);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOnGround)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                isOnGround = false;
            }
            else
            {
                if (isDoubleJumping == false)
                {
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    isDoubleJumping = true;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isOnGround = true;
            isDoubleJumping = false;
        }
    }
}
