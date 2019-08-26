using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockFunctionning : MonoBehaviour
{
    //Serializable
    [Header("My components")]
    [SerializeField] Animator myAnim = default;

    [Header("Gameobjects to serialize")]
    [SerializeField] GameObject daysPanel = default;
    [SerializeField] GameObject hoursPanel = default;

    //Private
    bool isOpened = false;

    private void Update()
    {
        daysPanel.SetActive(isOpened);
        hoursPanel.SetActive(isOpened);
    }

    public void HasBeenClickedOn()
    {
        isOpened = !isOpened;
        myAnim.SetBool("IsOpened", isOpened);
    }
}