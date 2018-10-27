using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class CarMovementScript : MonoBehaviour {
    
    public Rigidbody rb;
    AudioSource racecar;
    public float forwardSpeed = 10;
    public float turnSpeed = 5;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        racecar = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        float value = Input.GetAxis("Vertical");
        value *= forwardSpeed;
        float turnAmount = Input.GetAxis("Horizontal")*turnSpeed;

        transform.Rotate(0, turnAmount, 0);
        rb.AddRelativeForce(0, 0, value);

        System.Random rnd = new System.Random();
        int rndVal = rnd.Next(1, 1000);
        if (rndVal > 50 && rndVal < 52)
        {
            racecar.Play();
        }

    }
}
