using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    //Serializable
    [SerializeField] MapPanelFunctionning mapPanel = default;
    [SerializeField] GameObject mapDistricts = default;

    private void Update()
    {
        if (mapPanel.isOpened)
        {
            mapDistricts.SetActive(true);
        }
        else
        {
            mapDistricts.SetActive(false);
        }
    }
}