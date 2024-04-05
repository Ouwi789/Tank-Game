using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text level;
    private float playerLevel;
    // Start is called before the first frame update
    void Start()
    {
        playerLevel = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().level;
        level.text = "Level: " + playerLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        playerLevel = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().level;
        level.text = "Level: " + playerLevel.ToString();
    }
}
