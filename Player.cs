using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setLocation();
    }
    public float lat = 1;
    public float lon = 100;
    public TextMeshProUGUI latText;
    public TextMeshProUGUI lonText;
    public void setLocation()
    {
        latText.SetText(lat.ToString("F2"));
        lonText.SetText(lon.ToString("F2"));
        lat += .001f;
        lon += .0010f;
    }
}
