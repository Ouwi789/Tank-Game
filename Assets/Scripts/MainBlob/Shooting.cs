using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;

    private Vector3 mousePos;

    public GameObject bullet;

    public Transform bulletTransform;
    public Transform bulletTransform2;

    public bool canFire;

    private float timer;

    private float timeBetweenFiring;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        timeBetweenFiring = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().reload;
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenFiring = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().reload;
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                timer = 0;
                canFire = true; 
            }
        }

        if (Input.GetMouseButton(0) && canFire)
        {
            canFire = false;
            //TODO Make sure bullet fires from the gun instead of the player
            if(bulletTransform2 != null)
            {
                Instantiate(bullet, new Vector3(bulletTransform.position.x, bulletTransform.position.y, bulletTransform.position.z), Quaternion.identity);
                Instantiate(bullet, new Vector3(bulletTransform2.position.x, bulletTransform2.position.y, bulletTransform2.position.z), Quaternion.identity);
            } else
            {
                Instantiate(bullet, new Vector3(bulletTransform.position.x, bulletTransform.position.y, bulletTransform.position.z), Quaternion.identity);
            }
            
        }

    }
}
