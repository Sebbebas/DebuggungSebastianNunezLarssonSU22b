using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doer_Temp_Final_V3 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 0.02f, Input.GetAxis("Vertical") * 0.02f, 0);
    }
}
