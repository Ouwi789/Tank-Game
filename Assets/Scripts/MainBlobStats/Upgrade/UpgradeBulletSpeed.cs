using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBulletSpeed : MonoBehaviour
{
    public void upgradeBulletSpeed()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints > 0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().bulletSpeed += 5;
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints -= 1;
        }
    }
}
