using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployRock : MonoBehaviour
{
    public GameObject rockPrefab;
    public float respawnTime;

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(rockWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(rockPrefab) as GameObject;
        a.transform.position = new Vector2(20, -4);
    }

    void Update()
    {
        
    }
    IEnumerator rockWave()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

}
