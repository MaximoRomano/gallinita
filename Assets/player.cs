using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
             clon = Instantiate(prefab);
            clon.transform.position = spawnPoint.transform.position;
        }
        
    }
}
