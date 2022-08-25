using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour // 점수판
{
    private TextMeshProUGUI scoreText;

    public int Points
    {
        get;
        private set;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();    
    }

    public void AddScore(int addPoint)
    {
        Points += addPoint;
        scoreText.text = "점수 : " + Points.ToString() + "점";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
