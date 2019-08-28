using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployManager : MonoBehaviour
{
    
    public GameObject RockPrefab; //Rock프리팹 불러오기
    public GameObject CloudPrefab; //Cloud프리팹 불러오기
    public GameObject BeesPrefab; //Bees프리팹 불러오기
    public GameObject ItemPrefab; //Item프리팹 불러오기

    private Vector2 screenBounds; //스크린 크기 측정

    private int respawnTime_Rock; //생성시간
    private int respawnTime_Cloud;
    private int respawnTime_Bees;
    private int respawnTime_Item;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); //카메라 시점 좌표
        
        StartCoroutine(RockWave()); 
        StartCoroutine(CloudWave());
        StartCoroutine(BeesWave());
        StartCoroutine(ItemWave()); //코루틴들
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
    IEnumerator RockWave()
    {
        while (true)
        {
            respawnTime_Rock = (int)Random.Range(2, 5);
            if (respawnTime_Rock != respawnTime_Bees && respawnTime_Rock != respawnTime_Cloud && respawnTime_Rock != respawnTime_Item)
            {
                Debug.Log("Random_Rock_suc");
                yield return new WaitForSeconds(3f);
                while (true)
                {
                    yield return new WaitForSeconds(respawnTime_Rock);
                    spawnRock();
                }
            }
            else
            {
                Debug.Log("Rewhile_Rock");
                continue;
            }
        }
    }
    IEnumerator CloudWave()
    {
        while (true) {
            respawnTime_Cloud = (int)Random.Range(3, 7);
            if (respawnTime_Cloud != respawnTime_Rock && respawnTime_Cloud != respawnTime_Bees && respawnTime_Cloud != respawnTime_Item)
            {
                Debug.Log("Random_Cloud_suc");
                yield return new WaitForSeconds(30f);
                while (true)
                {
                    yield return new WaitForSeconds(respawnTime_Cloud);
                    spawnCloud();
                }
            }
            else
            {
                Debug.Log("Rewhile_Cloud");
                continue;
            }
        }
    }
    IEnumerator BeesWave()
    {
        while (true)
        {
            respawnTime_Bees = (int)Random.Range(5, 10);
            if (respawnTime_Bees != respawnTime_Rock && respawnTime_Bees != respawnTime_Cloud && respawnTime_Bees != respawnTime_Item)
            {
                Debug.Log("Random_Bees_suc");
                yield return new WaitForSeconds(60f);
                while (true)
                {
                    yield return new WaitForSeconds(respawnTime_Bees);
                    spawnBees();
                }
            }
            else
            {
                Debug.Log("Rewhile_Bees");
                continue;
            }
        }
    }
    IEnumerator ItemWave()
    {
        while (true)
        {
            respawnTime_Item = (int)Random.Range(1, 3);
            if (respawnTime_Item != respawnTime_Rock && respawnTime_Item != respawnTime_Cloud && respawnTime_Item != respawnTime_Cloud)
            {
                Debug.Log("Random_Item_suc");
                var HP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
                if (HP.currentHP < 5)
                {
                    yield return new WaitForSeconds(1f);
                    while (true)
                    {
                        yield return new WaitForSeconds(respawnTime_Item);
                        spawnItem();
                    }
                }
            }
            else
            {
                Debug.Log("Rewhile_Item");
                continue;
            }
        }
    }


}
