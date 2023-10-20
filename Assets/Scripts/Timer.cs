using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float time = 30f;

    private void Update()
    {
        time -= Time.deltaTime;
        float roundedTime = Mathf.RoundToInt(time);
        timerText.text = roundedTime.ToString() + "s";

        if (time < 0)
        {
            time = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
