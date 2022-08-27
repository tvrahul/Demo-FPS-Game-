using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag; //for storing tag name
    public bool lookAtPlayer = false;
    public GameObject theSoldier; //we put our soldier in this gameobject
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;
    public int genHurt; //varible for store genHurt 
    public AudioSource[] hurtSound; //Array for storing more than 1 sounds
    public GameObject hurtFlash;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))//it will check what is the tag through the Raycast
        {
            hitTag = hit.transform.tag;
            
        } 
        if(hitTag == "Player" && isFiring == false)  //if there is tag of Player it will start shooting
        {
            StartCoroutine(EnemyFire());
        }
        if(hitTag != "Player") //otw it will stay on idle condition
        {
            theSoldier.GetComponent<Animator>().Play("demo_combat_idle");
            lookAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        theSoldier.GetComponent<Animator>().Play("demo_combat_shoot", -1, 0);
        theSoldier.GetComponent<Animator>().Play("demo_combat_shoot"); //It will take Animator component of the applied gameobject(Soldier's) and play the fire animation.
        fireSound.Play();
        lookAtPlayer = true;
        GlobalHealth.healthValue -= 5;
        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(.2f);
        hurtFlash.SetActive(false);
        genHurt = Random.Range(0, 3); //storing 3 sounds randomly in genHurt variable
        hurtSound[genHurt].Play(); //playing 3 of them ramdom sounds
        yield return new WaitForSeconds(fireRate);
        isFiring = false;

    }
}
