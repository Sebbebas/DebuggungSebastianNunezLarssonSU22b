using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    void Update()
    {
        // should probably make it so the things cant look bad
        transform.localScale = transform.localScale + new Vector3(Random.Range(-0.2f,0.2f), Random.Range(-0.2f,0.2f), 0);
    }
}
