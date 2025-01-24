using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    int maxHealthPoint = 5; //최대 체력 선언
    private int healthPoint; //체력 선언. private로 노출 방지

    public int GetMaxHP()
    {
        return maxHealthPoint;
    }

    public int GetCurrentHP()
    {
        return healthPoint;
    }

    public void DecreaseHp() //public으로 제작. 체력 감소용
    {
        healthPoint -= 1;

        if (healthPoint <= 0) //혹시 0보다 같거자 작다면?
        {
            healthPoint = 0; //0으로
            Die(); //사망 함수 호출
        }
    }
    void Die() //사망 함수 선언
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
