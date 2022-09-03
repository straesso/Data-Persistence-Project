using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.IO;
using UnityEngine.UI;

public class MainDataManager : MonoBehaviour
{
    public static MainDataManager InstanceOfMainDataManager;

    public string playerName;
    public int highScore;



    private void Awake()
        {
            if (InstanceOfMainDataManager != null)
            {
                Destroy(gameObject);
                return;
            }

            InstanceOfMainDataManager = this;
            DontDestroyOnLoad(gameObject);

        }
}
