using UnityEngine;
using UnityEngine.UI;

public class SphereManagerChe : MonoBehaviour
{
    private static SphereManagerChe instance;  // ��������

    public int count = 0;
    public Text countText; // ������ �� UI Text ��� ����������� ��������

    // ����� ��� ��������� ���������� ���������
    public static SphereManagerChe GetInstance()
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
            countText.text = "Count Cherri: " + count.ToString() + "/15";
        }
    }
}
