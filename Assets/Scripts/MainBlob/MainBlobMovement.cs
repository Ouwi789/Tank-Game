using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBlobMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    private float horizontalInput = 0;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    
    void Start()
    {
        rb2d = GetComponent < Rigidbody2D> ();
        sr = GetComponent<SpriteRenderer>();
     
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        manageSpriteFlip(); 
    }
    void FixedUpdate()
    {
        manageInput();
    }
    void manageSpriteFlip()
    {
        if(horizontalInput > 0)
        {
            sr.flipX = false;
        } else if(horizontalInput < 0)
        {
            sr.flipX = true;
        }
    }
    void manageInput()
    {
        Vector2 totalMovement = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            totalMovement.y += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            totalMovement.x -= 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            totalMovement.y -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            totalMovement.x += 1;
        }
        rb2d.MovePosition(rb2d.position+totalMovement.normalized*Time.deltaTime*speed);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Clasher"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().health -= 20;
        }
    }
}
