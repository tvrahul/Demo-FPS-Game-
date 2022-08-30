using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashRemove : MonoBehaviour
{
    [SerializeField] bool flashOff = false;

    // Update is called once per frame
    void Update()
    {
        if (flashOff == false)
        {
            flashOff = true;
            StartCoroutine(FlashOff());
        }
    }

    IEnumerator FlashOff()
    {
        yield return new WaitForSeconds(.2f);
        flashOff = false;
        this.gameObject.SetActive(false);
    }
    

}
