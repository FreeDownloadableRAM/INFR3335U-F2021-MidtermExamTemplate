using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void OnStartButton_Pressed()
    {
        //Close Game
        Application.Quit();

    }
}
