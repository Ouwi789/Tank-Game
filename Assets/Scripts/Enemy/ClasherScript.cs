using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasherScript : MonoBehaviour
{
    public float speed;
    public float health;
    private Rigidbody2D rb2d;
    private Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void FixedUpdate()
    {
        moveToPlayer();
    }
    public void moveToPlayer()
    {
        Vector2 totalMovement = Vector2.zero;
        if(Mathf.Abs(transform.position.x - playerPosition.position.x) < 0.1f)
        {
            totalMovement.x = 0;
        }
        else if(transform.position.x > playerPosition.position.x)
        {
            totalMovement.x = -1;
        }
        else
        {
            totalMovement.x = 1;
        }
        if (Mathf.Abs(transform.position.y - playerPosition.position.y) < 0.1f)
        {
            totalMovement.y = 0;
        }
        else if (transform.position.y > playerPosition.position.y)
        {
            totalMovement.y = -1;
        }
        else
        {
            totalMovement.y = 1;
        }
        rb2d.MovePosition(rb2d.position + totalMovement.normalized * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            health -= GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().damage;
        }
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
