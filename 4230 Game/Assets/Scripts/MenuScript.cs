using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas ControlsCanvas;

    void Awake()
    {
        ControlsCanvas.enabled = false;
        Cursor.visible = true;
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Controls()
    {
        MainCanvas.enabled = false;
        ControlsCanvas.enabled = true;
    }

    public void Return()
    {
        ControlsCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
