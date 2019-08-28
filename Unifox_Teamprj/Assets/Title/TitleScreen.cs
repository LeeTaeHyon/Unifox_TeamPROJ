using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    private FadeManager theFade;
    
    // Start is called before the first frame update
    void Start()
    {
        theFade = FindObjectOfType<FadeManager>();

    }

    // Update is called once per frame
    public void StartGame()
    {
        StartCoroutine(GameStartCoroutine());
    }
    IEnumerator GameStartCoroutine()
    {
        theFade.FadeOut();
        yield return new WaitForSeconds(2f);
        //Scene
    }
}
