using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TitleUiMove : MonoBehaviour
{
    Vector2 TitleMove;
    public bool InputKey {  get; set; }
    void Start()
    {
        TitleMove = transform.position;
        TitleMove.x = 7;
        TitleMove.y = 0.5f;
    }

        
 
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            InputKey= true;

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            InputKey = false;
        }

        if (InputKey == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, transform.position.z), 0.1f);
        }

        if (InputKey == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(7, transform.position.y, transform.position.z), 0.1f);
        }
    }
}
