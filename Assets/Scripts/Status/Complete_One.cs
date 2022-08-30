using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Complete_One : MonoBehaviour
{
   public static int enemyCount;
    public static int treasureCount;
    public GameObject enemyDisplay;
    public GameObject treasureDisplay;
    public static int nextFloor = 4;

    // Update is called once per frame
    void Update()
    {
        enemyDisplay.GetComponent<TextMeshProUGUI>().text = "" + enemyCount;
        treasureDisplay.GetComponent<TextMeshProUGUI>().text = "" + treasureCount;
    }
}
