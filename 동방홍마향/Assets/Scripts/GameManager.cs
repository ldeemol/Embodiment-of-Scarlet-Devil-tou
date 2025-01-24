using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //단일 인스턴스

    public bool Gameover;
    int score;


    void Awake()
    {
        if (instance == null)
        {
            instance = this; //최초 실행일 경우
        }
        else
        {
            Destroy(gameObject); //아니면 파괴
        }
        DontDestroyOnLoad(gameObject); //씬 전환시 유지
    }

    void Start()
    {
        score = 0; //점수 초기화
    }

    public void YouDie()
    {
        Gameover=true;
        
    }

    public void NomalAddScore()
    {
        score += 100; //내가 가진 스코어에 100 추가
    }
    public int SeeScore()
    {
        return score;
    }
    public void ResetScore()
    {
        score = 0;
    }

}