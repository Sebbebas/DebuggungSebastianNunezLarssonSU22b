using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyScript : MonoBehaviour
{
    [SerializeField] string Enemy = "Enemy";
    void Update()
    {
        transform.Translate(0.02f,0, 0 * Time.deltaTime);
        transform.Rotate(0, 0, 0.2f * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == Enemy)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0 * Time.deltaTime);
            Destroy(other.gameObject);
        }
    }
}
