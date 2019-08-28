using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScore : MonoBehaviour
{

    public int scoreget = 0;

    public Text scoreTx;
    private void Start()
    {
        var Score_get = GameObject.Find("Scorepanel").GetComponent<ScoreManager>();
    }
    void Awake()
    {
        //scoreTx = GameObject.Find("UI").transform.FindChild("scoreTx").GetComponent<Text>();
        var Score_get = GameObject.Find("Scorepanel").GetComponent<ScoreManager>();
        scoreget = Score_get.scorePoint;
        showScore(scoreget);
        
    }

    public void showScore(int plusPoint)
    {
        scoreTx.text = "Score : " + plusPoint;
    }


}
