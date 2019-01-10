using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour {

    public void OnInstructionClick()
    {
        SceneManager.LoadScene("instructions");
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("main game");
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }
}
