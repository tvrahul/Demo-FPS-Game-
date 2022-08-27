using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int scoreValue =  0;
    public int internalScore;

    

    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "" + scoreValue;
    } 
}
