using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{

    public static UImanager Instance {  get; private set; }

    [SerializeField] TMP_Text TplayTime;
    [SerializeField] TMP_Text TclickCount;
    public TMP_InputField TplayerName;

    public void Awake()
    {
        Instance = this;
    }

    public void UpdateUI(GameData data)
    {
        TplayTime.text = data.playTime.ToString();
        TclickCount.text = data.clickCount.ToString();
        TplayerName.text = data.playerName.ToString();
    }

}
