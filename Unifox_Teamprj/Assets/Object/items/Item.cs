using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    //private Vector2 screenBounds;
 

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    void Update()
    {
        /*if(transform.position.x < screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }    
        */


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "OBReset")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            //int Sel = (int)Random.Range(1, 3);
            int Sel = 1;
            if (Sel == 1)
            {
                var HP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
                if (HP.currentHP == 5)
                {
                    Debug.Log("YOu full HP");
                }
                else if (HP.currentHP <= 4)
                {
                    HP.currentHP += 1;
                    Debug.Log("Healed+1");
                }
                
            }
            Destroy(this.gameObject);
        }
    }
}
