using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody2D enemyBulletRb; 
    Vector2 moveDirection; 
    GameObject playerInfo; 

    void Start()
    {
        enemyBulletRb = GetComponent<Rigidbody2D>(); 
        playerInfo = GameObject.Find("Player"); 

        moveDirection = (playerInfo.transform.position - transform.position);

        moveDirection.Normalize();

        enemyBulletRb.AddForce(moveDirection * 200); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall") 
        {
            Destroy(gameObject);
        }

    
        if (collision.tag == "Player") 
        {
            collision.gameObject.GetComponent<PlayerStatus>().DecreaseHp();
            Destroy(gameObject); 
        }


    }

}
