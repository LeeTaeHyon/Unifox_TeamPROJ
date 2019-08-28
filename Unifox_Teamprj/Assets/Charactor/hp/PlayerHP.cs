using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public static PlayerHP instance;

    public int currentHP = 5;

    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            if (currentHP > 1)
            {
                currentHP -= 1;
                Debug.Log("HP : " + currentHP);

            }
            else if (currentHP == 1)
            {
                currentHP -= 1;
                //Destroy(this.gameObject);
                Debug.Log("You Died");
                SceneManager.LoadScene(3);
            }
            
        }
    }

}
