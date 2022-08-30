using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    [SerializeField] GameObject theDoor; //Reference of GameObjects 
    [SerializeField] AudioSource doorFX;

     void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpen"); //Get the Animator Component of the GameObject and play particular Animation 
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
        
        
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5f);
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorClose");
        this.GetComponent<BoxCollider>().enabled = true;
    }


}
