using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    public Rigidbody rb;
    float horizontalInput;

    private void FixedUpdate() {
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + horizontalMove);

    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}

