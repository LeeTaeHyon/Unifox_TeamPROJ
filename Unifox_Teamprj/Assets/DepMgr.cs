using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepMgr : MonoBehaviour
{

    public GameObject RockPrefab; //Rock프리팹 불러오기
    public GameObject CloudPrefab; //Cloud프리팹 불러오기
    public GameObject BeesPrefab; //Bees프리팹 불러오기
    public GameObject ItemPrefab; //Item프리팹 불러오기

    private Vector2 screenBounds; //스크린 크기 측정

    public float timeLeast;
    public float timeMax;

    public int startWait;

    private float spawnTime;
    private int rand;

    private float timer = 0;

    public float Startcor;

    public float current_time=0;

 

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); //카메라 시점 좌표
    }

    void Update()
    {
        spawnTime = Random.Range(timeLeast, timeMax);
        //rand = (int)Random.Range(1, 4
        timer += Time.deltaTime;
        if(timer > Startcor)
        {
            timer = 0;
            StartCoroutine(Deploy());
        }
        

    }

    private void spawnRock()
    {
        GameObject a = Instantiate(RockPrefab) as GameObject;
        a.transform.position = new Vector2(20, -4);
    }
    private void spawnCloud()
    {
        GameObject a = Instantiate(CloudPrefab) as GameObject;
        a.transform.position = new Vector2(20, (float)2.3);
    }
    private void spawnBees()
    {
        GameObject a = Instantiate(BeesPrefab) as GameObject;
        a.transform.position = new Vector2(20, (float)1.5);
    }
    private void spawnItem()
    {
        GameObject a = Instantiate(ItemPrefab) as GameObject;
        a.transform.position = new Vector2(20, (float)-3.68);
    }

    IEnumerator Deploy()
    {
        var HP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
        rand = Random.Range(1, 4);
       
     
            yield return new WaitForSeconds(startWait);
            if (rand == 1)
            {
                while (true)
                {
                    yield return new WaitForSeconds(spawnTime);
                    spawnRock();
                }
            }
            else if (rand == 2)
            {
                while (true)
                {
                    yield return new WaitForSeconds(spawnTime);
                    spawnCloud();
                }
            }
            else if (rand == 3)
            {
                while (true)
                {
                    yield return new WaitForSeconds(spawnTime);
                    spawnBees();
                }
            }
            else if (rand == 4)
            {
                while (true)
                {  
                    spawnItem();
                    yield return new WaitForSeconds(spawnTime);
                }
            }
     
    }
    


}
