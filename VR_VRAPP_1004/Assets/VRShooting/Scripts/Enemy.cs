using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour // 총알 맞으면?
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
    
    void OnHitBullet() // 총 맞은 함수.
    {
        audioSource.PlayOneShot(hitclip);
        GoDown();
    }

    void GoDown()
    {
        score.AddScore(points);
        enemtCollider.enabled = false; // 콜라인더 비활성화
        Destroy(gameObject, 1f); // 나 자신 제거
    }
}
