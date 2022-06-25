using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public float distance = 15f;
    public float height = 7f;
    public Transform player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        offset = new Vector3(0, height, distance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}

