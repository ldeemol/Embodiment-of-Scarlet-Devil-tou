using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    TitleUiMove titleUiMove;

    GameObject GM;

    void Start()
    {
        titleUiMove = GameObject.Find("AllUi").GetComponent<TitleUiMove>();
        GM = GameObject.Find("GameManager");

    }

    void Update()
    {
        if (titleUiMove.InputKey == true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                GM.GetComponent<GameManager>().ResetScore();
                SceneManager.LoadScene("1Stage");
            }
        }
    }
}
