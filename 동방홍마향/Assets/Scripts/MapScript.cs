using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    Vector2 BackGroundMove;
    void Start()
    {
        BackGroundMove.x = -3;
        BackGroundMove.y = 14;
    }

    
    void Update()
    {
        if (BackGroundMove.y > -14)
        {
            BackGroundMove.y -= 0.0005f;
        }
        transform.position = BackGroundMove;
    }
}
