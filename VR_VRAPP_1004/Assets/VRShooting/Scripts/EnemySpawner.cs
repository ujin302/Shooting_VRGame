using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour // 적을 지정된 위치 방향에 보여주기
{
    public GameObject enemyPrefab;
    private GameObject enemy;
    
    public void Spawn()
    {
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
}
