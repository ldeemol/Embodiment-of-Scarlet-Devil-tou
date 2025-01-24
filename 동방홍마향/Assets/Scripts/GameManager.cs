using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //���� �ν��Ͻ�

    public bool Gameover;
    int score;


    void Awake()
    {
        if (instance == null)
        {
            instance = this; //���� ������ ���
        }
        else
        {
            Destroy(gameObject); //�ƴϸ� �ı�
        }
        DontDestroyOnLoad(gameObject); //�� ��ȯ�� ����
    }

    void Start()
    {
        score = 0; //���� �ʱ�ȭ
    }

    public void YouDie()
    {
        Gameover=true;
        
    }

    public void NomalAddScore()
    {
        score += 100; //���� ���� ���ھ 100 �߰�
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