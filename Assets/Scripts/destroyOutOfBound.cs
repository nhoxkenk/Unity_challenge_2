using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBound : MonoBehaviour
{
    public float topBound = 40.0f;
    public float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
