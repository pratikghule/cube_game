using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;

    void Start()
    {
       // rb.AddForce(0,200,500);

    }

    
    void FixedUpdate()
    {
       // rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1); //C#

        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,2000f*Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-2000f*Time.deltaTime,0,0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-2000f*Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(2000f*Time.deltaTime,0,0);
        }


    }
}
