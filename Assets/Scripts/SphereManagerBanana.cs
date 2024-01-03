using UnityEngine;
using UnityEngine.UI;

public class SphereManagerBanana : MonoBehaviour
{
    private static SphereManagerBanana instanceBanana;  // Синглтон

    public int countBanana = 0;
    public Text countTextBanana; // Ссылка на UI Text для отображения счетчика

    // Метод для получения экземпляра синглтона
    public static SphereManagerBanana GetInstanceBanana()
    {
        return instanceBanana;
    }

    private void Awake()
    {
        // Убедимся, что есть только один экземпляр синглтона
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
