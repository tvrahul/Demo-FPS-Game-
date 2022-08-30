using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKey : MonoBehaviour
{
    [SerializeField] GameObject firstKeyUI;
    [SerializeField] GameObject lockedTrigger;
    [SerializeField] GameObject Key;

    private void OnTriggerEnter(Collider other)
    {
        firstKeyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Key.SetActive(false);
    }
}
