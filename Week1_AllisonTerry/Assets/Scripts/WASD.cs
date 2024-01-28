using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WASD : MonoBehaviour
{
    public float forceAmt;
    Rigidbody rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(forceAmt * Vector3.left);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce((forceAmt *Vector3.forward));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce((forceAmt *Vector3.right));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(forceAmt * Vector3.back);
        }
        
    
    }


}
