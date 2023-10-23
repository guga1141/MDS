using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void StartJourney()
    {
        Debug.Log("THE JOURNEY HAS BEGUN");
    }
           
    public void QuitGame()
    {
        Debug.Log("THE PLAYER HAS LEFT");

        Application.Quit();
    }
}
