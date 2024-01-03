using UnityEngine;
using UnityEngine.UI;

public class SphereManagerBanana : MonoBehaviour
{
    private static SphereManagerBanana instanceBanana;  // ��������

    public int countBanana = 0;
    public Text countTextBanana; // ������ �� UI Text ��� ����������� ��������

    // ����� ��� ��������� ���������� ���������
    public static SphereManagerBanana GetInstanceBanana()
    {
        return instanceBanana;
    }

    private void Awake()
    {
        // ��������, ��� ���� ������ ���� ��������� ���������
        if (instanceBanana != null && instanceBanana != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instanceBanana = this;
        }
    }

    public void IncrementCount()
    {
        countBanana++;
        UpdateCountText();
    }

    private void UpdateCountText()
    {
        if (countTextBanana != null)
        {
            countTextBanana.text = "Count of Bananas: " + countBanana.ToString() + "/10";
        }
    }
}
