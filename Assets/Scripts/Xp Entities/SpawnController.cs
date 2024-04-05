using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    private float speedTimer;
    private float squareTimer;
    private float triangleTimer;
    private float clasherTimer;

    public GameObject square;
    public GameObject triangle;
    public GameObject clasher;

    public bool canSpawnSquare;
    public bool canSpawnTriangle;
    public bool canSpawnClasher;

    public float squareSpawnTime;
    public float triangleSpawnTime;
    public float clasherSpawnTime;

    public int numberOfSquares;
    public int numberOfTriangles;
    public int numberOfClashers;

    public int maxSquares;
    public int maxTriangles;
    public int maxClashers;
    // Start is called before the first frame update
    private void Awake()
    {
        maxSquares = 20;
        maxTriangles = 30;
        maxClashers = 10;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Speed Change
        speedTimer += Time.deltaTime;
        if(speedTimer >= 10)
        {
            changeTimes();
            speedTimer = 0;
        }
        numberOfSquares = GameObject.FindGameObjectsWithTag("Square").Length;
        numberOfTriangles = GameObject.FindGameObjectsWithTag("Triangle").Length;
        numberOfClashers = GameObject.FindGameObjectsWithTag("Clasher").Length;
        //Square Management
        if (!canSpawnSquare)
        {
            squareTimer += Time.deltaTime;
            if(squareTimer >= squareSpawnTime)
            {
                canSpawnSquare = true;
                squareTimer = 0;
            }
        } else
        {
            if(numberOfSquares < maxSquares)
            {
                canSpawnSquare = false;
                spawnSquare();
            }
        }
        //Triangle Management
        if (!canSpawnTriangle)
        {
            triangleTimer += Time.deltaTime;
            if (triangleTimer >= triangleSpawnTime)
            {
                canSpawnTriangle = true;
                triangleTimer = 0;
            }
        }
        else
        {
            if (numberOfTriangles < maxTriangles)
            {
                canSpawnTriangle = false;
                spawnTriangle();
            }
        }
        //Clasher Managerment
        if (!canSpawnClasher)
        {
            clasherTimer += Time.deltaTime;
            if (clasherTimer >= clasherSpawnTime)
            {
                canSpawnClasher = true;
                clasherTimer = 0;
            }
        }
        else
        {
            if (numberOfClashers < maxClashers)
            {
                canSpawnClasher = false;
                spawnClasher();
            }
        }
    }
    private void changeTimes()
    {
        squareSpawnTime *= 0.7f;
        triangleSpawnTime *= 0.7f;
        clasherSpawnTime *= 0.5f;
    }
    private void spawnSquare()
    {
        var position = new Vector3(Random.Range(-70.0f, 65.0f), Random.Range(48, -30.0f), 0);
        Instantiate(square, position, Quaternion.identity);
    }

    private void spawnTriangle()
    {
        var position = new Vector3(Random.Range(-70.0f, 65.0f), Random.Range(48, -30.0f), 0);
        Instantiate(triangle, position, Quaternion.identity);
    }
    private void spawnClasher()
    {
        var position = new Vector3(Random.Range(-70.0f, 65.0f), Random.Range(48, -30.0f), 0);
        Instantiate(clasher, position, Quaternion.identity);
    }
    public void restart()
    {
        canSpawnSquare = true;
        canSpawnTriangle = true;
        canSpawnClasher = true;
        speedTimer = 0;
        squareSpawnTime = 10;
        triangleSpawnTime = 5;
        clasherSpawnTime = 20;
        maxSquares = 20;
        maxTriangles = 30;
        maxClashers = 10;
    }
}
