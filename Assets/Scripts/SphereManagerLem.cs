using UnityEngine;
using UnityEngine.UI;

public class SphereManagerLemon : MonoBehaviour
{
    private static SphereManagerLemon instance;  // ��������

    public int count = 0;
    public Text countText; // ������ �� UI Text ��� ����������� ��������

    // ����� ��� ��������� ���������� ���������
    public static SphereManagerLemon GetInstance()
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
            countText.text = "Count of Lemon: " + count.ToString() + "/7";
        }
    }
}
