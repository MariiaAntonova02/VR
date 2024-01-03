using UnityEngine;
using UnityEngine.UI;

public class SphereManagerApple : MonoBehaviour
{
    private static SphereManagerApple instanceApple;  // ��������

    public int countApple = 0;
    public Text countTextApple; // ������ �� UI Text ��� ����������� ��������

    // ����� ��� ��������� ���������� ���������
    public static SphereManagerApple GetInstanceApple()
    {
        return instanceApple;
    }

    private void Awake()
    {
        // ��������, ��� ���� ������ ���� ��������� ���������
        if (instanceApple != null && instanceApple != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instanceApple = this;
        }
    }

    public void IncrementCount()
    {
        countApple++;
        UpdateCountTextA();
    }

    private void UpdateCountTextA()
    {
        if (countTextApple != null)
        {
            countTextApple.text = "Count of apple: " + countApple.ToString() + "/10";
        }
    }
}
