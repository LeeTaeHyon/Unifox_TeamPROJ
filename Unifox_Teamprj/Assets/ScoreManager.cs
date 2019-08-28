using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int scorePoint = 0;

    public Text scoreTx;
  
    void Awake()
    {
        //scoreTx = GameObject.Find("UI").transform.FindChild("scoreTx").GetComponent<Text>();
        scoreTx.text = "Score : 0";
        StartCoroutine("PlusScoreRoutine");
    }

    public void PlusScore(int plusPoint)
    {
        scorePoint += plusPoint;

        scoreTx.text = "Score : " + scorePoint.ToString("N0");
    }

    IEnumerator PlusScoreRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            PlusScore(5);
        }
    }
    
}
