using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FullHealthCollect : MonoBehaviour
{
    
    
    [SerializeField] AudioSource healthCollectSound;
   
    void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;
       
        healthCollectSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
        


    }
}
