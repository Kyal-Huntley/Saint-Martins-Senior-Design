using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PanelManager : MonoBehaviour
{
    public GameObject[] Panels;
    public bool panelStatus0 = false;
    public bool panelStatus1 = false;
    public bool panelStatus2 = false;
    public bool panelStatus3 = false;
    public bool panelStatus4 = false;

    private void Awake()
    {
        Panels[0].SetActive(panelStatus0);
        Panels[1].SetActive(panelStatus1);
        Panels[2].SetActive(panelStatus2);
        Panels[3].SetActive(panelStatus3);
        Panels[4].SetActive(panelStatus4);
    }

    public void OpenFirstPanel()
    {
        if (panelStatus0 == false)
        {
            panelStatus0 = true;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(true);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
        else if (panelStatus0 == true)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
    }
    public void OpenSecondPanel()
    {
        if (panelStatus1 == false)
        {
            panelStatus0 = false;
            panelStatus1 = true;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(true);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
        else if (panelStatus1 == true)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
    }
    public void OpenThirdPanel()
    {
        if (panelStatus2 == false)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = true;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(true);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
        else if (panelStatus2 == true)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
    }
    public void OpenFourthPanel()
    {
        if (panelStatus3 == false)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = true;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(true);
            Panels[4].SetActive(false);
        }
        else if (panelStatus3 == true)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
    }
    public void OpenlastPanel()
    {


        if (panelStatus4 == false)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = true;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(true);
        }
        else if (panelStatus4 == true)
        {
            panelStatus0 = false;
            panelStatus1 = false;
            panelStatus2 = false;
            panelStatus3 = false;
            panelStatus4 = false;

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
        }
    }
}
