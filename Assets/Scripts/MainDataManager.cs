using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MainDataManager : MonoBehaviour
{
    public static MainDataManager InstanceOfMainDataManager;

    public string highScorePlayer;
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

    [System.Serializable]
    class SaveData
    {
        public string highScorePlayer;
        public int highScore;
    }

    public void StoreData()
    {
        SaveData data = new SaveData();
        data.highScorePlayer = highScorePlayer;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScorePlayer = data.highScorePlayer;
            highScore = data.highScore;
        }
    }


}
