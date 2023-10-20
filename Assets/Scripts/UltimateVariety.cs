using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UltimateVariety : MonoBehaviour
{
    [Header("Wobble")]
    [SerializeField, Tooltip("Changes the object size at random")] bool doesWobble = false;
    [SerializeField] float wobbleForce = 0.02f;

    [Header("Move")]
    [SerializeField, Tooltip("Moves the object in random directions")] bool doesMove = false;
    [SerializeField] float moveForce = 0.02f;

    [Header("Collision")]
    [SerializeField, Tooltip("Increase the size when colliding with other objects")] bool changeSize = false;
    [SerializeField] float sizeIncrease = 0.5f;
    [SerializeField, Tooltip("Player tag")] string player = "Player";
    [SerializeField, Tooltip("Enemy tag")] string enemy = "Enemy";
    [SerializeField, Tooltip("Antidote tag")] string antidote = "Antidote";


    void Update()
    {
        if (doesWobble)
        {
            transform.localScale = transform.localScale + new Vector3(Random.Range(-wobbleForce, wobbleForce), Random.Range(-wobbleForce, wobbleForce), 0);
        }
        if (doesMove)
        {
            transform.position = transform.position + new Vector3(Random.Range(-moveForce, moveForce), Random.Range(-moveForce, moveForce), Random.Range(0, 0));
        }
    }

    //Enemys / Antidote
    void OnCollisionEnter2D(Collision2D other)
    {
        //Reloads the scene when collides with player
        if (other.gameObject.tag == player && gameObject.tag == enemy)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(other.gameObject.tag == antidote && changeSize)
        {
            transform.localScale -= new Vector3(sizeIncrease, sizeIncrease, 0);
            Destroy(other.gameObject);
        }
    }
}
