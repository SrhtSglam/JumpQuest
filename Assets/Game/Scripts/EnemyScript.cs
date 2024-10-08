using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject leftConditionBlock, rightConditionBlock;
    bool condition;

    private void Update()
    {
        if (condition == true)
        {
            transform.position = new Vector2(transform.position.x + 0.02f, transform.position.y);
        }
        else if(condition == false)
        {
            transform.position = new Vector2(transform.position.x - 0.02f, transform.position.y);
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
