using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpBar : MonoBehaviour
{
    private Transform bar;
    private float xp;
    private float maxXp;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        xp = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().xp;
        maxXp = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().requiredXp;
    }

    // Update is called once per frame
    void Update()
    {
        xp = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().xp;
        maxXp = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().requiredXp;
        setSize(normalizeXPNumber(xp, maxXp));
    }

    public float normalizeXPNumber(float xp, float maxXP)
    {
        return xp / maxXP;
    }

    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }
}
