using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneChange : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown && GameObject.Find("GameManager").GetComponent<GameManager>().Gameover == true)
        {
            SceneManager.LoadScene("EndScenes");
            GameObject.Find("GameManager").GetComponent<GameManager>().Gameover = false;
        }
    }
}
