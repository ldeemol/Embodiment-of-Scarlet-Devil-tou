using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombStar : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall") //충돌 대상 태그가 Wall이라면?
        {
            Destroy(gameObject);
        }

        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Translate(0, 0.1f, 0);
    }
}
