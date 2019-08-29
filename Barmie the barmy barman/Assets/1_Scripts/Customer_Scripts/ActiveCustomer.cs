using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCustomer : MonoBehaviour
{
    [Header("My components")]
    [SerializeField] Animator myAnim = default;

    [Header("Serializable")]
    [SerializeField] Customer[] allCustomers = default;

    //Private
    int customerActiveQueue = 0;

    
}