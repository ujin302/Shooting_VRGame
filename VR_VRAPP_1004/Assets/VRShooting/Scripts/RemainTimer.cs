using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainTimer : MonoBehaviour // ���� �ð� ����
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

        timeText.text = "���� �ð� : " + currentTime.ToString("N2") + "��"; // N2 �Ҽ��� 2�ڸ�����
    }

    public bool IsCountingDown() // currentTime�� 0�� �ƴϸ� true
    {
        return currentTime > 0.0f;
    }
}
