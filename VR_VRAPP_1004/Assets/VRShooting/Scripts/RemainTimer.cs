using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainTimer : MonoBehaviour // 남은 시간 측정
{
    public float gamaTime = 30.0f;
    private TextMeshProUGUI timeText;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        currentTime = gamaTime;
        Debug.Log(IsCountingDown());
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0f)
        {
            currentTime = 0.0f;
            Debug.Log(IsCountingDown());
        }

        timeText.text = "남은 시간 : " + currentTime.ToString("N2") + "초"; // N2 소수점 2자리까지
    }

    public bool IsCountingDown() // currentTime가 0이 아니면 true
    {
        return currentTime > 0.0f;
    }
}
