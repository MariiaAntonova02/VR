using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    [SerializeField] public float initialTime;
    [SerializeField] public Text timerText;
    [SerializeField] public Text buttonText;

    public float currentTime;

    bool timerRunning = false;

    public IEnumerator StartTimer()
    {
        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }

    public void Start()
    {
        currentTime = initialTime;
        StartCoroutine(StartTimer());
    }

    public void UpdateTimeText()
    {
        if (timerRunning)
        {
            if (currentTime < 0)
                currentTime = 0;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);
            timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }

    public void ButtonTimer()
    {
        timerRunning = !timerRunning;

        buttonText.text = timerRunning ? "Pause" : "Start";
    }
    public void RestartGame()
    {
        // Перезапускаем текущий уровень
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}