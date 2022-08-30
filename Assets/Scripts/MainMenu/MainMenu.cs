using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] AudioSource clickSound;
    [SerializeField] GameObject fadeOut;

    [SerializeField] int loadScene;
    [SerializeField] int loadLives;
    [SerializeField] int loadScore;
    [SerializeField] int loadAmmo;

    public void NewGame()
    {
        StartCoroutine(NewGameCycle());
    }

    IEnumerator NewGameCycle()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetGame()
    {
        PlayerPrefs.SetInt("SceneToLoad",0); //Save(SetInt) information in playerfrefs that we have completed floor One
        PlayerPrefs.SetInt("LivesSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("AmmoSaved",0);
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad");
        if (loadScene == 0)
        {
            //nothing happens
        }
        else
        {
            StartCoroutine(LoadGameCycle());
        }
    }

    IEnumerator LoadGameCycle()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad"); //Store out GetInt informations in this Variables through GetInt
        loadLives = PlayerPrefs.GetInt("LivesSaved");
        loadScore = PlayerPrefs.GetInt("ScoreSaved");
        loadAmmo = PlayerPrefs.GetInt("AmmoSaved");
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        Complete_One.nextFloor = loadScene;
        GlobalLife.lifeValue = loadLives;
        Score.scoreValue = loadScore;
        GlobalAmmo.handgunAmmo = loadAmmo;
        SceneManager.LoadScene(loadScene);

    }
}
