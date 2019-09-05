using UnityEngine;
using System.Collections;

// The velocity in y is 10 units per second.  If the GameObject starts at (0,0,0) then
// it will reach (0,100,0) units after 10 seconds.

public class velocidadMaxima : MonoBehaviour
{
    private Rigidbody rb;

    private float t = 0.0f;
    private bool moving = false;

    public Vector3 velocidadM_s = new Vector3(0,10,0);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // the cube is going to move upwards in 10 units per second
            rb.velocity = velocidadM_s;
            moving = true;
        }
    }
}
