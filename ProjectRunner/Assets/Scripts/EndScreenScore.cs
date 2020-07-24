using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreenScore : MonoBehaviour
{
    private TextMeshProUGUI bscore;
    private TextMeshProUGUI curscore;
    private void Start()
    {
        bscore = GameObject.FindGameObjectWithTag("scoresys").GetComponent<TextMeshProUGUI>();
        curscore = GameObject.FindGameObjectWithTag("scoresys2").GetComponent<TextMeshProUGUI>();
        bscore.text = PlayerPrefs.GetFloat("hscore").ToString("0");
        curscore.text = Score.cscore.ToString("0");
    }
}
