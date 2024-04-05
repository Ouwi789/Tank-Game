using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb2d;
    public float force;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        force = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().bulletSpeed;
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb2d = GetComponent<Rigidbody2D>();
        mousePos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 direction = transform.position - mousePos;
        Vector3 rotation = mousePos - transform.position;
        rb2d.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().damage;
    }

    // Update is called once per frame
    void Update()
    {
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().damage;
        force = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Square") || collision.gameObject.tag.Equals("Triangle") || collision.gameObject.tag.Equals("Clasher"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().xp += damage;
        }
        if (!collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }

}
