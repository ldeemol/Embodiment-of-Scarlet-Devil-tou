using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalEnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; //�� ��ü �����ռ��赵
    float coolTime;   //��Ÿ���� �� ����
    float spawnSpeed; //��ȯ �ӵ�
    Vector3 tempPosition; //�ӽ� ��ġ ����
    int spawnCount; //��ȯ�� �� ��ü �� ����

    void Start()
    {
        coolTime = 0; //��Ÿ�� �ʱⰪ
        spawnSpeed = 300; //��ȯ �ֱ� �ʱⰪ
        tempPosition = Vector3.zero; //��ȯ��ġ �ʱⰪ
        spawnCount = 0; //��ȯ ����� 0���� ����
    }

    void Update()
    {
        coolTime++;

        if (spawnCount < 10) //���� ��ȯ�� ������ 10�� �̸��̶��?
        {
            if (coolTime > spawnSpeed)
            {
                tempPosition = transform.position;

                Instantiate(enemyPrefab, tempPosition, transform.rotation);

                spawnCount++; 

                coolTime = 0;
            }
        }
    }
}
