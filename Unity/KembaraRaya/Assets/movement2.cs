using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float maxVelocity;
    public float reverseVelocity;

    private AudioSource engineNoise;
    private Rigidbody rb;
    private float velocityMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        rb = GetComponent<Rigidbody>();
        engineNoise = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if(v == -1){
            h *= -1;
        }
 
        rb.AddTorque(0f,h * turnSpeed, 0f);
        rb.AddForce(-transform.up * v * speed);

        velocityMagnitude = rb.velocity.magnitude;
        if(v == 1){
            rb.velocity += -transform.up * 0.1f;
            if(rb.velocity.sqrMagnitude > maxVelocity){
                rb.velocity *= 0.99f;
            }
            engineNoise.pitch = 1.5f;
        }
        else if(v == -1){
            rb.velocity += transform.up * 0.001f;
            if(rb.velocity.sqrMagnitude > reverseVelocity){
                rb.velocity *= 0.95f;
            }
        }
        else {
            engineNoise.pitch = 1f;
        }
    }
}
