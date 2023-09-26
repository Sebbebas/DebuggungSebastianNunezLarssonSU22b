using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] a;
    [SerializeField] GameObject s;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, .5f);
    }

    void SpawnEnemy()
    {
        Instantiate(a[Random.Range(0, a.Length-1)], transform.position, Quaternion.identity);
    }
}
