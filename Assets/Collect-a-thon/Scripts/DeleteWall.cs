using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWall : MonoBehaviour
{
    public GameObject[] zombies;
    public int threshold;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int remaining = 0;

        foreach (GameObject obj in zombies)
        {
            if (obj != null)
                remaining++;
        }

        if (remaining <= threshold && gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
