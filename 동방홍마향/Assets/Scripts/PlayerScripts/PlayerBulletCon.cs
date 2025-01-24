using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBulletCon : MonoBehaviour
{
    float moveSpeed = 15f;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall") //�浹 ��� �±װ� Wall�̶��?
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
      
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
