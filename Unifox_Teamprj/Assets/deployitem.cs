using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployitem : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float respawnTime;

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(RockWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(ItemPrefab) as GameObject;
        a.transform.position = new Vector2(20, (float)-3.68);
    }

    void Update()
    {
        
    }
    IEnumerator RockWave()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

}
