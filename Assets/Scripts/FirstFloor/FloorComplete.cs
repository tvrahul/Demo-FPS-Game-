using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject completePanel;
    [SerializeField] GameObject player;
    [SerializeField] GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(FloorCompleted());
        player.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator FloorCompleted()
    {
        fadeOut.SetActive(true);
        Complete_One.nextFloor += 1;
        PlayerPrefs.SetInt("SceneToLoad", Complete_One.nextFloor); //Save(SetInt) information in playerfrefs that we have completed floor One
        PlayerPrefs.SetInt("LivesSaved", GlobalLife.lifeValue);
        PlayerPrefs.SetInt("ScoreSaved", Score.scoreValue);
        PlayerPrefs.SetInt("AmmoSaved", GlobalAmmo.handgunAmmo);

        yield return new WaitForSeconds(2f);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(15f);
        Score.scoreValue = 0;
        Complete_One.enemyCount = 0;
        Complete_One.treasureCount = 0;
        
        SceneManager.LoadScene(Complete_One.nextFloor);
    }
}
