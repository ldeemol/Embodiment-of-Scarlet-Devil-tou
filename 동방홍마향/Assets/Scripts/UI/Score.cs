using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text text;
    GameObject FindScoreText;
    int score;

    void Start()
    {
        text = GetComponent<Text>();
        FindScoreText = GameObject.Find("GameManager");
    }


    void Update()
    {
        score = FindScoreText.GetComponent<GameManager>().SeeScore();

        text.text = score.ToString();


    }
}
