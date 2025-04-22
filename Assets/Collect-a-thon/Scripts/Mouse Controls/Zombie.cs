using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    public float activationRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 playerPosition = new Vector3(player.position.x, currentPosition.y, player.position.z);

        float distance = Vector3.Distance(new Vector3(currentPosition.x, 0, currentPosition.z), new Vector3(player.position.x, 0, player.position.z));

        if (distance <= activationRange)
        {
            transform.position = Vector3.MoveTowards(currentPosition, playerPosition, moveSpeed * Time.deltaTime);
        }

    }
}