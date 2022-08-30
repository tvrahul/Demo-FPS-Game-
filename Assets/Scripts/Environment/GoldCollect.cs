using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldCollect : MonoBehaviour
{
    
    [SerializeField] GameObject goldPlates;
    [SerializeField] AudioSource goldCollectSound;
    [SerializeField] GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
        Score.scoreValue += 500;
        Complete_One.treasureCount += 1;
        goldPlates.SetActive(false);
        goldCollectSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<TextMeshProUGUI>().text = "!!Golddd!!";
        pickUpDisplay.SetActive(true);


    }
}
