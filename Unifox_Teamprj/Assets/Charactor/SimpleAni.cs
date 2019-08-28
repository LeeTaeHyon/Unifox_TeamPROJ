using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAni : MonoBehaviour
{

    [SerializeField]
    private Sprite[] frameArray;
    [SerializeField]
    private Sprite[] frameArray_Hit;
    [SerializeField]
    private Sprite[] frameArray_NR;

    private int currentFrame;
    private float timer;
    private float framerate = .1f;
    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameWk
    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            gameObject.GetComponent<SpriteRenderer>().sprite = frameArray[currentFrame];
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            frameArray = frameArray_Hit;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        frameArray = frameArray_NR;
    }
}
