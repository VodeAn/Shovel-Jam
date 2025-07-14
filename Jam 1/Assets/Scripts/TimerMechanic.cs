using System;
using TMPro;
using UnityEngine;

public class TimerMechanic : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] TextMeshProUGUI timerText;
    void Start()
    {

    }

    
    void Update()
    {
        Timer();
    }
    public void Timer()
    {

        if (duration > 0)
        {
            duration -= Time.deltaTime;
        }
        else
        {
            duration = 0;
        }
        int minutes = Mathf.FloorToInt(duration / 60);
        int seconds = Mathf.FloorToInt(duration % 60);

        timerText.text = string.Format("{00:00}:{1:00}",minutes,seconds);
    }
}
