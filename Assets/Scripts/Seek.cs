using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] bool targetPlayer;
    [SerializeField] bool targetEnemy;
    [SerializeField] float movementspeed = 5;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        if (targetPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, movementspeed * Time.deltaTime);

            if (transform.localScale.x < 0.5 || transform.localScale.y < 0.5)
            {
                Destroy(this);
            }
        }
        else if(targetEnemy)
        {
            GameObject moveTowardsThis = GameObject.FindWithTag("Enemy");
            transform.position = Vector3.MoveTowards(transform.position, moveTowardsThis.transform.position, movementspeed * Time.deltaTime);
        }
    }
}
