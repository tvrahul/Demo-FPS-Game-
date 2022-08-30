using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAdding : MonoBehaviour
{

    [SerializeField] AudioSource lifeCollectSound;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }
     void OnTriggerEnter(Collider other)
    {
        lifeCollectSound.Play();
        GlobalLife.lifeValue += 1;
        this.gameObject.SetActive(false);   
    }
}
