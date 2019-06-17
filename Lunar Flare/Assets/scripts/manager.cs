using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class manager : MonoBehaviour
{
    #region Singleton

    public static Player instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    public GameObject gamewonUI;
    public GameObject gamelostUI;
    public float restartdelay = 20f;

    void Win()
    {
        if (pedestalslit = 5)
        {
            gamewonUI.SetActive(true);
            Instantiate (SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex), restartdelay);
        }

        if (player.collisionInfo.GetComponent<enemybehaviour>)
        { 
            if (enemybehvaiour!= null)
            {
                gamelostUI.SetActive(true);
                Instantiate(SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex), restartdelay);
            }
        }
    }


}
