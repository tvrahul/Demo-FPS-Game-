using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgunAmmo; //static = bcz we need to access this variable from different script
    [SerializeField] GameObject ammoDisplay;

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.GetComponent<TextMeshProUGUI>().text = "" + handgunAmmo;
    }
}
