﻿using UnityEngine;

public class Playermovement : MonoBehaviour
{
public Rigidbody rb;

public float forwardForce = 2000f;
public float sidewaysForce = 500f;
public float jumpForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKeyDown("space") )
        {
        rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        
        }

        if ( Input.GetKey("d") )
        {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        
        if ( Input.GetKey("a") )
        {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();       
        }
    }
}
