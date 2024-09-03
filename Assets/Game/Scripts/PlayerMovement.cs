using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject gm;
    Rigidbody2D rb;
    SpriteRenderer sr;
    float speed = 5f;
    Vector2 movement;

    public Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            sr.flipX = true;
        if (Input.GetKeyDown(KeyCode.D))
            sr.flipX = false;

        if (Input.GetAxis("Horizontal") != 0f)
            anim.SetBool("IsRun", true);
        else
            anim.SetBool("IsRun", false);

        if (Input.GetKeyDown(KeyCode.W))
            rb.velocity = Vector2.up * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gm.GetComponent<GameManager>().coinAmount++;
        }
    }
}
