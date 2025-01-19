using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    private TMP_Text timer_display;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Init();
        timer_display = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        timer += Time.deltaTime;
        DisplayTime(timer);
    }

    public void Init()
    {
        timer = 0;
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;

        timer_display.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
    }
}
