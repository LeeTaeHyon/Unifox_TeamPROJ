using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] Nextsprite;
    private SpriteRenderer spriteRenderer;
    //PlayerHP playerHP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
    
    void Start()
    {
        //int HP = GameObject.Find("NR_O").GetComponent<PlayerHP>().currentHP;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Nextsprite[1];
    }

    // Update is called once per frame
    void Update()
    {
        var HP = GameObject.Find("NR_O").GetComponent<PlayerHP>();
        if(HP.currentHP == 5)
        {
            spriteRenderer.sprite = Nextsprite[0];
        }
        else if(HP.currentHP == 4)
        {
            spriteRenderer.sprite = Nextsprite[1];
        }
        else if(HP.currentHP == 3)
        {
            spriteRenderer.sprite = Nextsprite[2];
        }
        else if(HP.currentHP == 2)
        {
            spriteRenderer.sprite = Nextsprite[3];
        }
        else if(HP.currentHP == 1)
        {
            spriteRenderer.sprite = Nextsprite[4];
        }
        else if(HP.currentHP == 0)
        {
            spriteRenderer.sprite = Nextsprite[5];
        }
    }
}
