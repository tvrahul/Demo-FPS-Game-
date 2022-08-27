using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GlobalLife : MonoBehaviour
{
    public GameObject lifeDisplay;
    public static int lifeValue =  3;
    public int internalLife;

    

    void Update()
    {
        internalLife = lifeValue;
        lifeDisplay.GetComponent<TextMeshProUGUI>().text = "" + lifeValue;
    } 
}
