using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script stores the actual score and shows it on screen in UI element.
public class ScoreGT : MonoBehaviour
{

    const int SCOREBIGAST = 100;
    const int SCOREMEDIUMAST = 200;
    const int SCORELITTLEAST = 400;


    // Declaration of variables
    // ====================================

    int actualScore = 0;
    Text txtScore;

    // ====================================

    

    void Awake()
    {

        txtScore = GetComponent<Text>();
    }


    void Start()
    {

        ShowScore();
    }


    /// <summary>
    /// Generate the new actual score on screen. We make a "," every three numerals.
    /// </summary>
    void ShowScore()
    {
        string finalText = "";
        string strActualScore = actualScore.ToString();
        int lngStr = strActualScore.Length;
        string elem = "";

        for (int i = 0; i < lngStr; i++)
        {
            elem = strActualScore.Substring(i, 1);
            finalText = string.Concat(finalText + elem);

            if (strActualScore.Length > 3 && finalText.Length == strActualScore.Length - 3)
                finalText = string.Concat(finalText + ",");
        }

        txtScore.text = finalText;
    }


    /// <summary>
    /// Add score in the actual score. A big ast gives 100 points, a medium ast gives 200 points and a little ast gives 400 points.
    /// This method is called in Asteroid.cs.
    /// </summary>
    /// <param name="size">The size of the asteroid (beetween 1 and 3 include)</param>
    public void AddScore(int size)
    {

        if (size == 3) actualScore += SCOREBIGAST;
        else if (size == 2) actualScore += SCOREMEDIUMAST;
        else actualScore += SCORELITTLEAST;

        ShowScore();
    }
}
