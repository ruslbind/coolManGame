using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;

    private int score = 0;
    private float time = 0f;

    void Update()
    {
        // ������ ���������� ��������� ���������
        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + time.ToString("F2"); // �������������� ������� � ����� ����������� �������
    }

    // ����� ��� ���������� �����
    public void IncreaseScore(int amount)
    {
        score += amount;
    }

    // ����� ��� ���������� �������
    public void UpdateTime(float newTime)
    {
        time = newTime;
    }
}
