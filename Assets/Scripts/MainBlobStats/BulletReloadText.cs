using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletReloadText : MonoBehaviour
{
    public Text bulletReload;
    private float reload;
    // Start is called before the first frame update
    void Start()
    {
        reload = GameObject.FindGameObjectWithTag("Reload").GetComponent<UpgradeBulletReload>().displayReload;
        bulletReload.text = "Bullet Reload: " + reload;
    }

    // Update is called once per frame
    void Update()
    {
        reload = GameObject.FindGameObjectWithTag("Reload").GetComponent<UpgradeBulletReload>().displayReload;
        bulletReload.text = "Bullet Reload: " + reload;
    }
}
