using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowTime : MonoBehaviour {

    public Slider slider;
    float timeScale = 0.0f;

    void Start()
    {
        slider.value = Time.timeScale;
    }

    public void ChangeTime(float time)
    {
        Time.timeScale = time;
    }

    public void Pause()
    {
        float tempScale = Time.timeScale;
        Time.timeScale = timeScale;
        timeScale = tempScale;
    }
}
