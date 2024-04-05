using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSpeedText : MonoBehaviour
{
    public Text bulletSpeed;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().bulletSpeed;
        bulletSpeed.text = "Bullet Speed: " + speed;
    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().bulletSpeed;
        bulletSpeed.text = "Bullet Speed: " + speed;
    }
}
