using UnityEngine;
using UnityEngine.UI;

public class SphereManager : MonoBehaviour
{
    private static SphereManager instance;  // ��������

    public int count = 0;
    public Text countText; // ������ �� UI Text ��� ����������� ��������

    // ����� ��� ��������� ���������� ���������
    public static SphereManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        // ��������, ��� ���� ������ ���� ��������� ���������
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void IncrementCount()
    {
        count++;
        UpdateCountText();
    }

    private void UpdateCountText()
    {
        if (countText != null)
        {
            countText.text = "Count of balls: " + count.ToString() + "/15";
        }
    }
}
