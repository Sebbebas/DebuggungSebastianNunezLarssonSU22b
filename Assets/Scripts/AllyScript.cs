using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyScript : MonoBehaviour
{
    [SerializeField] string Enemy = "Enemy";
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 3f;
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0 );
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == Enemy)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0);
            Destroy(other.gameObject);
        }
    }
}
