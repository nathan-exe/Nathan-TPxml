using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Windows;

public class JsonManager : FileManager
{
    const string path = "Assets/testJson.json";
    public override GameData LoadData()
    {
        if (!System.IO.File.Exists(path)) throw new System.IO.FileNotFoundException();

        //byte[] bytes = System.IO.File.ReadAllBytes(path);
        //string json = Convert.ToBase64String(bytes);
        string json = System.IO.File.ReadAllText(path);

        return JsonUtility.FromJson<GameData>(json);
    }

    public override void SaveData(GameData data)
    {
        string json = JsonUtility.ToJson(data,true);

        //byte[] bytes =  Convert.FromBase64String(json);
        //System.IO.File.WriteAllBytes(path, bytes);
        System.IO.File.WriteAllText(path, json);
    }

}
