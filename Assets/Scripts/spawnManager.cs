using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] spawnArray;
    public int spawnCount;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimal", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnAnimal()
    {
        spawnCount = Random.Range(0, spawnArray.Length);
        Instantiate(spawnArray[spawnCount], new Vector3(Random.Range(-20,20), 0, 20), spawnArray[spawnCount].transform.rotation);
    }
}
