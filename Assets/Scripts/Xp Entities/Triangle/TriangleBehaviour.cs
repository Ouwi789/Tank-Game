using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleBehaviour : MonoBehaviour
{
    public float health;
    private float rotZ;
    // Start is called before the first frame update
    void Start()
    {
        rotZ = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        rotZ += 0.5f;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Square") || collision.gameObject.tag.Equals("Wall") || collision.gameObject.tag.Equals("Triangle"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            health -= collision.gameObject.GetComponent<ProjectileBehaviour>().damage;
        }
    }
    public void manageHealthBar()
    {

    }
}
