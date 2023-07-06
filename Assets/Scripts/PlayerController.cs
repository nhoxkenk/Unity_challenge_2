using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float getInput;
    public float boundRange = 20.0f;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > boundRange)
        {
            transform.position = new Vector3(boundRange, 0, 0);
        }else if(transform.position.x < -boundRange)
        {
            transform.position = new Vector3(-boundRange, 0, 0);
        }
        getInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * getInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = new Vector3(transform.position.x, 0, 0);
            Instantiate(projectile, spawnPos, transform.rotation);
        }
    }
}
