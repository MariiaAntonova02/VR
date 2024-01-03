using UnityEngine;
using UnityEngine.UI;

public class SphereManagerChe : MonoBehaviour
{
    private static SphereManagerChe instance;  // Синглтон

    public int count = 0;
    public Text countText; // Ссылка на UI Text для отображения счетчика

    // Метод для получения экземпляра синглтона
    public static SphereManagerChe GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        // Убедимся, что есть только один экземпляр синглтона
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
