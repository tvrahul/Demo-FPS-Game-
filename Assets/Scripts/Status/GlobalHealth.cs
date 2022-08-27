using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    public int internalHealth;

     void Start()
    {
        healthValue = 100;
    }

    void Update()
    {
        if(healthValue <= 0) //if health value is  0 it will load GameRestart(gameover) scene
        {
            SceneManager.LoadScene(1); //It will load the scene that index we pass
        }
        internalHealth = healthValue;
        healthDisplay.GetComponent<TextMeshProUGUI>().text = "" + healthValue + "%";
    } 
}
