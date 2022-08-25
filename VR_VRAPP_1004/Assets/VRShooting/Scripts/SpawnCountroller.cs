using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCountroller : MonoBehaviour // ���� �ð����Ŀ�, ���� �������� ���� ��Ű��
{
    public float spawnInterval = 2f;

    EnemySpawner[] spawners;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawners = GetComponentsInChildren<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(spawnInterval < timer)
        {
            int index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();
            Debug.Log("�迭����: " + spawners.Length);
            timer = 0f;
        }
    }
}
