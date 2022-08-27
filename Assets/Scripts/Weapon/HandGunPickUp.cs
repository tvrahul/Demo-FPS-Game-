using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandGunPickUp : MonoBehaviour
{
    [SerializeField] GameObject realHandgun;
    [SerializeField] GameObject fakeHandgun;
    [SerializeField] AudioSource handgunPickUpSound;
    [SerializeField] GameObject pickUpDisplay;

     void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        fakeHandgun.SetActive(false);
        handgunPickUpSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<TextMeshProUGUI>().text = "HANDGUN COLLECTED";
        pickUpDisplay.SetActive(true);


    }


}
