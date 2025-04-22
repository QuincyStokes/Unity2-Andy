using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor : MonoBehaviour
{
    public GameObject wall;
    bool touching;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!touching)
        {
            if(wall.transform.position.y > 7)
            {
                wall.transform.position -= new Vector3(0, 0.1f, 0);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            touching = true;
            if(wall.transform.position.y < 15)
            {
                wall.transform.position += new Vector3(0, 0.1f, 0);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        touching = false;
    }
}
