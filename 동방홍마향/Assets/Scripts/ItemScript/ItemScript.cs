using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DestroyEnemy")
        {
            Destroy(gameObject);
        }
    }
        Rigidbody2D ItemRb;
    void Start()
    {
        ItemRb = GetComponent<Rigidbody2D>();
        ItemRb.AddForce(new Vector3(0,5), ForceMode2D.Impulse);
    }
}
