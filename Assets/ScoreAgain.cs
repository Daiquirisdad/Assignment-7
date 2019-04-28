using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAgain : MonoBehaviour
{

    public Text score;
    public Text failText;
    public static int scoreInt = 0;
    public static int fails = 0;

    public void toText()
    {
        score.text = scoreInt.ToString();
        failText.text = fails.ToString();
    }

    void Start()
    {
        toText();
    }

    void Update()
    {
        toText();
    }

}
