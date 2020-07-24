using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private float startTime, elapsedTime;
    public static float cscore;
    public TextMeshProUGUI text;

    private void Start()
    {
        startTime = Time.time;
    }
    private void Update()
    {
        elapsedTime = Time.time - startTime;
        cscore = elapsedTime * 10;
        text.text = cscore.ToString("0");
        if (cscore > PlayerPrefs.GetFloat("hscore", 0))
        {
            PlayerPrefs.SetFloat("hscore", cscore);
            PlayerPrefs.Save();
        }
    }
}
