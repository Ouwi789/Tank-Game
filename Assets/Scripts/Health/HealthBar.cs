using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;
    private float health;
    private float maxHealth;
    private bool isTriangle = false;
    private bool isSquare = false;
    private bool isClasher = false;
    private bool isPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        if (transform.parent.GetComponent<TriangleBehaviour>() != null)
        {
            health = transform.parent.GetComponent<TriangleBehaviour>().health;
            maxHealth = transform.parent.GetComponent<TriangleBehaviour>().health;
            isTriangle = true;          
        }
        else if (transform.parent.GetComponent<SquareBehaviour>() != null)
        {
            health = transform.parent.GetComponent<SquareBehaviour>().health;
            maxHealth = transform.parent.GetComponent<SquareBehaviour>().health;
            isSquare = true;
        }
        else if (transform.parent.GetComponent<ClasherScript>() != null)
        {
            health = transform.parent.GetComponent<ClasherScript>().health;
            maxHealth = transform.parent.GetComponent<ClasherScript>().health;
            isClasher = true;
        } else if(transform.parent.GetComponent<MainBlobLevel>() != null)
        {
            health = transform.parent.GetComponent<MainBlobLevel>().health;
            maxHealth = transform.parent.GetComponent<MainBlobLevel>().health;
            isPlayer = true;
        }
        
    }
    private void Update()
    {
        if (isSquare)
        {
            health = transform.parent.GetComponent<SquareBehaviour>().health;
        }else if(isTriangle){
            health = transform.parent.GetComponent<TriangleBehaviour>().health;
        } else if(isClasher)
        {
            health = transform.parent.GetComponent<ClasherScript>().health;
        } else if (isPlayer)
        {
            health = transform.parent.GetComponent<MainBlobLevel>().health;
        }
        
        if (health <= 0 && !isPlayer)
        {
            Destroy(this.gameObject);
        }
        setSize(normalizeHealthNumber(health, maxHealth));
    }

    public float normalizeHealthNumber(float health, float maxHealth)
    {
        return health / maxHealth;
    }

    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

}
