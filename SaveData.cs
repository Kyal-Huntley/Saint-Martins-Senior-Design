using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public float lat;
    public float lon;

    public SaveData(Player player)
    {
        lat = player.lat;
        lon = player.lon;
    }
}
