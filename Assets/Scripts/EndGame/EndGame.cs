using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private GameObject player;
    private GameObject gameController;
    private GameObject endUI;
    private GameObject inGameUI;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
        inGameUI = GameObject.FindGameObjectWithTag("InGameUI");
        endUI = GameObject.FindGameObjectWithTag("EndUI");
        endUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<MainBlobLevel>().health <= 0)
        {
            CloseGame();
        }
    }
    void CloseGame()
    {
        if(GameObject.FindGameObjectWithTag("InGameUI") != null)
        {
            GameObject.FindGameObjectWithTag("InGameUI").SetActive(false);
        }
        if (endUI != null)
        {
            endUI.SetActive(true);
        }
        gameController.GetComponent<SpawnController>().maxSquares = 0;
        gameController.GetComponent<SpawnController>().maxTriangles = 0;
        gameController.GetComponent<SpawnController>().maxClashers = 0;
        DestroyAll("Square");
        DestroyAll("Triangle");
        DestroyAll("Clasher");
    }
    void DestroyAll(string tag)
    {
        GameObject[] entities = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < entities.Length; i++)
        {
            Destroy(entities[i]);
        }
    }
    public void restart()
    {
        inGameUI.SetActive(true);
    }
}
