using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LazerBullet : MonoBehaviour
{
    Color TempColor; 
    bool isForward; 

    void Start()
    {
        TempColor = new Color(1, 1, 1, 0); 
        isForward = true; 
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (isForward == true)
            {
                TempColor.a += 0.01f;

                if (TempColor.a >= 1.0f)
                    isForward = false;
            }

            if (isForward == false)
            {
                TempColor.a -= 0.01f;

                if (TempColor.a <= 0.0f)
                    isForward = true;
            }

            GetComponent<SpriteRenderer>().color = TempColor;
        }

    }

}
