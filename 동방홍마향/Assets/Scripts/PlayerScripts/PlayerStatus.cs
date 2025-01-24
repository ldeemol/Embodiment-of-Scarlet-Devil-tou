using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    int maxHealthPoint = 5; //�ִ� ü�� ����
    private int healthPoint; //ü�� ����. private�� ���� ����

    public int GetMaxHP()
    {
        return maxHealthPoint;
    }

    public int GetCurrentHP()
    {
        return healthPoint;
    }

    public void DecreaseHp() //public���� ����. ü�� ���ҿ�
    {
        healthPoint -= 1;

        if (healthPoint <= 0) //Ȥ�� 0���� ������ �۴ٸ�?
        {
            healthPoint = 0; //0����
            Die(); //��� �Լ� ȣ��
        }
    }
    void Die() //��� �Լ� ����
    {
        if (healthPoint <= 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().YouDie();
            Destroy(gameObject);
        }
    }

    void Start()
    {
        healthPoint = 5;
    }

}
