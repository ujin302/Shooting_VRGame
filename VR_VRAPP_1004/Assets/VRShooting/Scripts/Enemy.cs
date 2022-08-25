using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour // �Ѿ� ������?
{
    public AudioClip spawnClip;
    public AudioClip hitclip;

    private AudioSource audioSource;
    private Collider enemtCollider;

    int points = 1;
    Score score;
    GameObject gameObj;

    private void Start()
    {
        enemtCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(spawnClip);

        gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();
    }
    
    void OnHitBullet() // �� ���� �Լ�.
    {
        audioSource.PlayOneShot(hitclip);
        GoDown();
    }

    void GoDown()
    {
        score.AddScore(points);
        enemtCollider.enabled = false; // �ݶ��δ� ��Ȱ��ȭ
        Destroy(gameObject, 1f); // �� �ڽ� ����
    }
}
