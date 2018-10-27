using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2MovementScript : MonoBehaviour {

    public Rigidbody rb;
    public float forwardSpeed = 10;
    public float turnSpeed = 5;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //Time.timeScale = .5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float value = Input.GetAxis("Vertical2");
        value *= forwardSpeed;
        float turnAmount = Input.GetAxis("Horizontal2") * turnSpeed;

        transform.Rotate(0, turnAmount, 0);
        rb.AddRelativeForce(0, 0, value);

    }
}
