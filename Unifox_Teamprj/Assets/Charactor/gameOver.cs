using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(hpCheck());
    }

    IEnumerator hpCheck()
    {
        while (true)
        {
            var HP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
            if (HP.currentHP == 0)
            {
                gameEndSc();
            }
            else
            {
                yield return 0;
            }
        }
    }

    void gameEndSc()
    {
        SceneManager.LoadScene(3);
    }
}
