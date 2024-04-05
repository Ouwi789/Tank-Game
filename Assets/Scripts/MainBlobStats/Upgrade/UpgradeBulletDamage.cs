using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBulletDamage : MonoBehaviour
{
    public void upgradeBulletDamage()
    {
        if(GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints > 0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().damage += 5;
            GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints -= 1;
        }
    }
}
