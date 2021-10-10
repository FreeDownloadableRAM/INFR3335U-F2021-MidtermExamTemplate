using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMenu : MonoBehaviour
{
    public void OnStartButton_Pressed() 
    {
        //Start game
        SceneManager.LoadScene(sceneName: "Start");

    }
}
