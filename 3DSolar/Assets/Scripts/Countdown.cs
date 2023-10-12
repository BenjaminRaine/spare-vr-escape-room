using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timer;
    
    public float remaining = 3600f;

    // Update is called once per frame
    void Update()
    {
        remaining -= Time.deltaTime;
        int minutes = (int) (remaining / 60);
        int seconds = (int) (remaining - minutes * 60);
        timer.text = String.Format("{0:00}:{1:00}", minutes, seconds);
        if (seconds + minutes <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
