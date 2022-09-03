using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField playerName;
    public int userScore;

    public void NewColorSelected(Color color)
    {
    }

    private void Start()
    {
    }

    public void StartNew()
    {
        //
        MainDataManager.InstanceOfMainDataManager.playerName = playerName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // MainManager.InstanceOfMainManager.SaveColor();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SaveColorClicked()
    {
        // MainManager.InstanceOfMainManager.SaveColor();
    }

    public void LoadColorClicked()
    {
        // MainManager.InstanceOfMainManager.LoadColor();
        // ColorPicker.SelectColor(MainManager.InstanceOfMainManager.TeamColor);
    }
}
