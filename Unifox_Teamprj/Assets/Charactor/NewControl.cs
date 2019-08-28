using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewControl : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float minJumpForce;
    private float moveInput;

    bool isJumping;
    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);
    }

    void Update()
    {
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * minJumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * minJumpForce;
        }
        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }      
        else if(Input.GetKeyDown(KeyCode.Space) && extraJumps == 0&&isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
