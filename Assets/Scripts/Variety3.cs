using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety3 : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3 (Random.Range(-.02f,.02f), Random.Range(-.02f,.02f), Random.Range(0,0));
        transform.position = transform.position + new Vector3(Random.Range(-.01f,.01f), Random.Range(-.01f,.01f), Random.Range(0,0));
    }
}
