using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movementspeed;
    public float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, movementspeed);
            transform.Translate(0,0,movementspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += new Vector3(0, 0, movementspeed);
            transform.Translate(0, 0, -movementspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(0, 0, movementspeed);
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(0, 0, movementspeed);
            transform.Rotate(0, -rotationSpeed, 0);
        }


    }
     
}
