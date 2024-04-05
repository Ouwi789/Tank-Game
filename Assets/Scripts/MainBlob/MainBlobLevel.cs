using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBlobLevel : MonoBehaviour
{
    public float xp;
    public float requiredXp;
    public float level;
    public float damage;
    public float bulletSpeed;
    public float skillPoints;
    public float health;
    public float reload;
    // Start is called before the first frame update
    void Awake()
    {
        level = 1;
        xp = 0;
        requiredXp = 50;
        damage = 10;
        bulletSpeed = 20;
        skillPoints = 0;
        health = 50;
        reload = 0.5f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(xp >= requiredXp)
        {
            level += 1;
            xp = 0;
            requiredXp *= 1.2f;
            skillPoints += 1;
        }
    }
    public void restart()
    {
        level = 1;
        xp = 0;
        requiredXp = 50;
        damage = 10;
        bulletSpeed = 20;
        skillPoints = 0;
        health = 50;
        reload = 0.5f;
    }
}
