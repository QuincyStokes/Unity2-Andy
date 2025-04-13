using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Vector3 spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Void"))
        {
            transform.position = spawnPoint;
            transform.rotation = new Quaternion (0, 0, 0, 0);
        }
    }
}
