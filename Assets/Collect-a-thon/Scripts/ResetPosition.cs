using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Vector3 spawnPoint;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Void") || (other.CompareTag("Acid") && CompareTag("Player")))
        {
            transform.position = spawnPoint;
            transform.rotation = Quaternion.identity;
        }
        else if(CompareTag("Box") && other.name == "Acid_1")
        {
            transform.position = new Vector3 (-253, 9, 44.5f);
            transform.rotation = Quaternion.identity;
        }
    }
}
