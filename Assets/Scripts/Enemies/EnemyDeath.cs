using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }
     
    void Update()
    {
        if(enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("Death"); //the enemy object hase ema Animator object gotine Death Animation Play karse
            enemyAI.SetActive(false);
            theEnemy.GetComponent<LookPlayer>().enabled = false;
            Score.scoreValue += 100;
            Complete_One.enemyCount += 1;
           
        }
    }
}
