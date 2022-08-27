using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoPick : MonoBehaviour
{

    
    [SerializeField] GameObject fakeAmmo;
    [SerializeField] AudioSource ammoPickUpSound;
    [SerializeField] GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
       
        fakeAmmo.SetActive(false);
        ammoPickUpSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        GlobalAmmo.handgunAmmo += 10; //Called handgunAmmo variable from GlobalAmmo script
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<TextMeshProUGUI>().text = "CLIP OF BULLET";
        pickUpDisplay.SetActive(true);


    }

}
