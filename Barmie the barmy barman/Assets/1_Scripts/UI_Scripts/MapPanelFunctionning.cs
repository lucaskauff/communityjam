using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPanelFunctionning : MonoBehaviour
{
    //Public
    [HideInInspector] public bool isOpened = false;

    //Serializable
    [SerializeField] Animator myAnim = default;

    public void MapHasBeenClickedOn()
    {
        isOpened = !isOpened;
        myAnim.SetBool("IsOpened", isOpened);
    }
}