using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointsText : MonoBehaviour
{
    public Text skillText;
    private float points;
    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints;
        skillText.text = "Stats(Skill Points: " + points.ToString() + ")";
    }

    // Update is called once per frame
    void Update()
    {
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<MainBlobLevel>().skillPoints;
        skillText.text = "Stats(Skill Points: " + points.ToString() + ")";
    }
}
