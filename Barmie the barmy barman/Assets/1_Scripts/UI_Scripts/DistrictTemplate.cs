using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistrictTemplate : MonoBehaviour
{
    //Public
    [HideInInspector] public bool isHighlighted = false;
    public string districtName = default;

    //Serializable
    [SerializeField] Animator myAnim = default;

    public void InfoToAnimator()
    {
        isHighlighted = !isHighlighted;
        myAnim.SetBool("IsHigh", isHighlighted);
    }
}