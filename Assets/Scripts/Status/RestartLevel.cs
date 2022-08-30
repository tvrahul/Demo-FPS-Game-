using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour
{
    public GameObject gameOver;
   
    // Start is called before the first frame update
    void Start()
    {
        GlobalLife.lifeValue -= 1;
        if (GlobalLife.lifeValue == 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            if (Complete_One.nextFloor == 4)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                SceneManager.LoadScene(Complete_One.nextFloor);
            }
        }
    }

    
}
