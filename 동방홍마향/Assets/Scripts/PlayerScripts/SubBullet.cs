using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBullet : MonoBehaviour
{
    float moveSpeed = 5.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall") //충돌 대상 태그가 Wall이라면?
        {
            Destroy(gameObject);
        }

        if (collision.tag == "Enemy")
        {
            collision.gameObject.GetComponent<NomalEnemy>().DecreaseHp();

            Destroy(gameObject);
        }

        if (collision.tag == "Pink")
        {

            collision.gameObject.GetComponent<pinkNormalEnemy>().DecreaseHp();
            Destroy(gameObject);
        }
    }

    void Update()
    {
        moveSpeed += 0.1f;
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
