using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10.0f;
    public float jumpForce = 1.0f;
    public float doubleJumpCooldown = 0.1f;
    private float doubleJumpCounter = 0.0f;
    private bool isOnGround = true;
    private bool isDoubleJumping = false;

    public Camera cam;
    public GameController gc;
    //private Animator anim;
    private Rigidbody2D rb;

    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(translation, 0, 0);
        
        if(transform.position.x > 10.8f)
        {
            cam.transform.position = new Vector3(transform.position.x, cam.transform.position.y, -3);
        }
        else
        {
            cam.transform.position = new Vector3(10.8f, cam.transform.position.y, -3);
        }

        if (translation < 0)
        {
            transform.localScale = new Vector3(-12.21469f, 11.1661f, 1);
            GetComponent<Animator>().SetBool("right", true);

        }
        else if (translation > 0)
        {
            transform.localScale = new Vector3(12.21469f, 11.1661f, 1);
            GetComponent<Animator>().SetBool("right", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("right", false);
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

        if (gc.playerHealth <= 0)
        {
            Destroy(gameObject);
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
