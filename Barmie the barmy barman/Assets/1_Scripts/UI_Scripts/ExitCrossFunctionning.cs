using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCrossFunctionning : MonoBehaviour
{
    //Serializable
    [SerializeField] GameObject pausePanel = default;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenPausePanel();
        }
    }

    public void HasBeenClickedOn()
    {
        OpenPausePanel();
    }

    void OpenPausePanel()
    {
        pausePanel.SetActive(true);
    }
}