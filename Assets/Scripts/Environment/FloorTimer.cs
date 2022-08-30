using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FloorTimer : MonoBehaviour
{
    [SerializeField] int secondCount;
    [SerializeField] int minutteCount;
    [SerializeField] GameObject timeDisplay;
    
    public bool addingTime = false;

    // Update is called once per frame
    void Update()
    {
        if(addingTime == false)
        {
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        addingTime = true;
        yield return new WaitForSeconds(1f);
        secondCount += 1;
        if(secondCount == 60)
        {
            secondCount = 0;
            minutteCount += 1;
        }
        if (secondCount <= 9)
        {
            timeDisplay.GetComponent<TextMeshProUGUI>().text = "0" + minutteCount + ":0" + secondCount;
        }
        else
        {
            timeDisplay.GetComponent<TextMeshProUGUI>().text = "0" + minutteCount + ":" + secondCount;
        }
        addingTime = false;
    }
}
