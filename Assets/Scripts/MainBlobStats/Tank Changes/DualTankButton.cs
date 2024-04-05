using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualTankButton : MonoBehaviour
{
    public GameObject doubleGun;
    public bool changed;
    public void turnToDual()
    {
        Destroy(GameObject.FindGameObjectWithTag("Gun"));
        var newGun = Instantiate(doubleGun, new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y, 0f), Quaternion.identity);
        newGun.transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        newGun.transform.localScale = new Vector3(1, 1);
        changed = true;
    }
}
