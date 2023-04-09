using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objetos;


    public Vector3[] spawnPos;
    private float startDelay = 0f;
    private float repeatDelay = 1f;

    //private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
        // playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        // if (playerControllerScript.gameOver == false)
        // {
            int randomPos = Random.Range(0,spawnPos.Length);
            int randomPrefab = Random.Range(0,objetos.Length);
            Instantiate(objetos[randomPrefab], spawnPos[randomPos], objetos[randomPrefab].transform.rotation);
        // }
    }
}
