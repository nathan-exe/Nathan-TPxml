using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    float _startPlayTime;
    FileManager _fileManager = new JsonManager();
    public void UpdateGameData()
    {
        UpdatePlayerName();
        UpdatePlaytime();
        IncrementClickCount();
        UImanager.Instance.UpdateUI(GameData);
    }

    public void UpdatePlayerName()
    {
        GameData.playerName = UImanager.Instance.TplayerName.text;
    }

    public void UpdatePlaytime()
    {
        GameData.playTime = _startPlayTime + Time.realtimeSinceStartup;
    }

    public void IncrementClickCount()
    {
        GameData.clickCount++;
    }


    private void Start()
    {
        LoadData();
        _startPlayTime = GameData.playTime;
        UImanager.Instance.UpdateUI(GameData);
    }

    public void saveData()
    {
        _fileManager.SaveData(GameData);
    }

    public void LoadData()
    {
        //GameData = new(0,0,"");
        try {GameData = _fileManager.LoadData(); } catch { Debug.LogWarning("no save file found"); };
        
    }
}
