using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingUi : MonoBehaviour
{
    Color TempColor;


    bool IsSee = false;

    void Start()
    {
        TempColor = new Color(1, 1, 1, 1);
      
    }


    void Update()
    {
        if (IsSee == false)
        {
            TempColor.a -= 0.01f;

            if (TempColor.a < 0.0f)
            {

                IsSee = true;
            }
        }

        if (IsSee == true)
        {
            TempColor.a += 0.01f;

            if (TempColor.a > 1.0f)
            {

                IsSee = false;
            }
        }

        GetComponent<Text>().color = TempColor;

    }
}
