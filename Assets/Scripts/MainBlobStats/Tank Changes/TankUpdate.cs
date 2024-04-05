using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankUpdate : MonoBehaviour
{
    private GameObject dualTank;
    private GameObject dualTankButton;
    public GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        dualTank = GameObject.FindGameObjectWithTag("DualTankButton");
        dualTankButton = GameObject.FindGameObjectWithTag("DualTank");
        dualTank.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().level >= 3 && !dualTankButton.GetComponent<DualTankButton>().changed)
        {
            dualTank.SetActive(true);
        }
        if(dualTankButton.GetComponent<DualTankButton>().changed)
        {
            dualTank.SetActive(false);
        }
        
    }
    public void restart()
    {
        dualTankButton.GetComponent<DualTankButton>().changed = false;
        Destroy(GameObject.FindGameObjectWithTag("DualGun"));
        Destroy(GameObject.FindGameObjectWithTag("Gun"));
        var newGun = Instantiate(gun, new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y, 0f), Quaternion.identity);
        newGun.transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        newGun.transform.localScale = new Vector3(1, 1);
    }
}
