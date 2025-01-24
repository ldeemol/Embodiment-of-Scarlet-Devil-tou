using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalEnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; //적 기체 프리팹설계도
    float coolTime;   //쿨타임을 잴 변수
    float spawnSpeed; //소환 속도
    Vector3 tempPosition; //임시 위치 저장
    int spawnCount; //소환한 적 기체 수 저장

    void Start()
    {
        coolTime = 0; //쿨타임 초기값
        spawnSpeed = 300; //소환 주기 초기값
        tempPosition = Vector3.zero; //소환위치 초기값
        spawnCount = 0; //소환 댓수는 0으로 시작
    }

    void Update()
    {
        coolTime++;

        if (spawnCount < 10) //아직 소환한 갯수가 10개 미만이라면?
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
