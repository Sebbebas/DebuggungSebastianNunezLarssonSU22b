using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float time = 30f;
    [SerializeField] TextMeshProUGUI timerText;

    Sceneloader sceneloader;

    private void Start()
    {
        sceneloader = GetComponent<Sceneloader>();
    }

    private void Update()
    {
        time -= Time.deltaTime;
        float roundedTime = Mathf.RoundToInt(time);
        timerText.text = roundedTime.ToString() + "s";

        if (time < 0)
        {
            time = 0;
            sceneloader.LoadSceneNumber(2);
        }
    }
}
