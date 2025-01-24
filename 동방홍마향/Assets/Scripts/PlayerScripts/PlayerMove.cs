using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rd;

    float speed = 5f;
    private void OnCollisionStay2D(Collision2D collision)
    {
        rd = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(horizontalInput, verticalInput);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 2.5f;
            transform.Translate(move * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift)==false)
        {
            speed = 5f;
            transform.Translate(move * speed * Time.deltaTime);
        }
    }
}
