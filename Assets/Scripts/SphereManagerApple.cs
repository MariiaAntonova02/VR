using UnityEngine;
using UnityEngine.UI;

public class SphereManagerApple : MonoBehaviour
{
    private static SphereManagerApple instanceApple;  // Синглтон

    public int countApple = 0;
    public Text countTextApple; // Ссылка на UI Text для отображения счетчика

    // Метод для получения экземпляра синглтона
    public static SphereManagerApple GetInstanceApple()
    {
        return instanceApple;
    }

    private void Awake()
    {
        // Убедимся, что есть только один экземпляр синглтона
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
