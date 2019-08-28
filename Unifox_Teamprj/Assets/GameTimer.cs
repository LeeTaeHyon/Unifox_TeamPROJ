using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{

    int countDownStartValue = 3;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            Debug.Log("Timer : " + countDownStartValue);
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            Debug.Log("TimerEnd");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
