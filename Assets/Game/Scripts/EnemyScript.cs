using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject leftConditionBlock, rightConditionBlock;
    bool condition;
    Rigidbody2D rb;
    float speed = 2f; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (condition == true)
        {
            transform.position = new Vector2(transform.position.x + 0.05f, transform.position.y);
        }
        else if(condition == false)
        {
            transform.position = new Vector2(transform.position.x - 0.05f, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Left"))
        {
            condition = true;
        }
        else if (collision.gameObject.CompareTag("Right"))
        {
            condition = false;
        }
    }
}
