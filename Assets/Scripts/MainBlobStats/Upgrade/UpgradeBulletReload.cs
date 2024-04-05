using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBulletReload : MonoBehaviour
{
    public float displayReload;
    private void Start()
    {
        displayReload = 1;
    }
    public void upgradeBulletReload()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints > 0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().reload *= 0.7f;
            displayReload += 1;
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints -= 1;
        }
    }
}
