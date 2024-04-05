using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamageText : MonoBehaviour
{
    public Text bulletDamage;
    private float damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().damage;
        bulletDamage.text = "Bullet Damage: " + damage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().damage;
        bulletDamage.text = "Bullet Damage: " + damage.ToString();
    }
}
