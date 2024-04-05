using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAgain : MonoBehaviour
{
    public void Retry()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnController>().restart();
        GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().restart();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<EndGame>().restart();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<TankUpdate>().restart();
        if (GameObject.FindGameObjectWithTag("EndUI") != null)
        {
            GameObject.FindGameObjectWithTag("EndUI").SetActive(false);
        }
        
    }
}
