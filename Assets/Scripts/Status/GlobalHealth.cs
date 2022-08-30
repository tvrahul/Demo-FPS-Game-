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
    [SerializeField] GameObject health100;
    [SerializeField] GameObject health75;
    [SerializeField] GameObject health50;
    [SerializeField] GameObject health25;

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

        if(healthValue >= 75)
        {
            health100.SetActive(true);
            health75.SetActive(false);
            health50.SetActive(false);
            health25.SetActive(false);
        }
        if(healthValue < 25)
        {
            health100.SetActive(false);
            health75.SetActive(false);
            health50.SetActive(false);
            health25.SetActive(true);
        }
        if(healthValue >= 25 && healthValue < 50)
        {
            health100.SetActive(false);
            health75.SetActive(false);
            health50.SetActive(true);
            health25.SetActive(false);
        }
        if (healthValue >= 50 && healthValue < 75)
        {
            health100.SetActive(false);
            health75.SetActive(true);
            health50.SetActive(false);
            health25.SetActive(false);
        }
    } 
}
