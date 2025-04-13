using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public float jumpStrength = 5;
    public KeyCode jumpKey = KeyCode.Space;

    private Rigidbody rb;
    private bool isGrounded = true;
    private string jumpTag;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            rb.AddForce(rb.transform.up * jumpStrength, ForceMode.Impulse);

        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Box"))
        {
            jumpTag = collision.gameObject.tag;
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(jumpTag))
        {
            isGrounded = false;
        }
    }
}
