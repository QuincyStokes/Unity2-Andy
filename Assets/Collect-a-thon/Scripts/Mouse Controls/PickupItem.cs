using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
public class PickupItem : MonoBehaviour, IPickup
{
    private Transform oldParent;
    private Rigidbody rb;
    private Collider coll;

    void Start()
    {
        oldParent = transform.parent;
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
    }

    public void Pickup(Transform newParent)
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        coll.enabled = false;

        transform.SetParent(newParent);

        transform.localPosition = Vector3.zero;
        transform.localEulerAngles = Vector3.zero;
    }

    public void Drop(float throwPower)
    {
        transform.SetParent(oldParent);
        rb.isKinematic = false;
        coll.enabled = true;
        rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.VelocityChange);
    }
}
