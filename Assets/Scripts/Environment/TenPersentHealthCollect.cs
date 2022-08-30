using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TenPersentHealthCollect : MonoBehaviour
{
    
    
    [SerializeField] AudioSource healthCollectSound;
   
    void OnTriggerEnter(Collider other)
    {
        if (GlobalHealth.healthValue >= 91)
        {
            GlobalHealth.healthValue = 100;
        }
        else
        {
            GlobalHealth.healthValue += 10;
        }
        healthCollectSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
        


    }
}
