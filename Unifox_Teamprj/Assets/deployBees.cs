using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployBees : MonoBehaviour
{
    public GameObject BeesPrefab;
    public float respawnTime = 1f;

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(rockWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(BeesPrefab) as GameObject;
        a.transform.position = new Vector2(20, (float)1.5);
    }
    IEnumerator rockWave()
    {
        yield return new WaitForSeconds(7f);
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

}
