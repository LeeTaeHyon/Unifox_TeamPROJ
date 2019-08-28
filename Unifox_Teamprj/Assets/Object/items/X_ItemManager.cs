using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


        // Update is called once per frame



        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                //int Sel = (int)Random.Range(1, 3);
                int Sel = 1;
                if (Sel == 1)
                {
                    var HP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
                    HP.currentHP += 2;
                    Debug.Log("Healed");
                }
                Destroy(this.gameObject);
            }
        }
    }
}
