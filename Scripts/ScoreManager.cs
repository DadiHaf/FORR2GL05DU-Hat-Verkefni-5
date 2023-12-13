using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int smStig = 1;
    public Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text> ();
    }

    void Update()
    {
        scoreText.text = "Stig" + smStig;
    }
}
