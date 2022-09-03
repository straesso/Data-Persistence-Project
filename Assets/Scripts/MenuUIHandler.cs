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
// [DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField playerName;
    public int userScore;
    public Text storedHighscoreText;

    private void Start()
    {
        MainDataManager.InstanceOfMainDataManager.LoadData();
        storedHighscoreText.text = "Best Score : " + MainDataManager.InstanceOfMainDataManager.highScorePlayer + " : " + MainDataManager.InstanceOfMainDataManager.highScore;
    }

    public void StartNew()
    {
        MainDataManager.InstanceOfMainDataManager.playerName = playerName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
