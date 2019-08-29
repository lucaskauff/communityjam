using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Customer", menuName = "Customer", order = 1)]
public class Customer : ScriptableObject
{
    public string customerName = "CustomerLambda";
    public Sprite customerSprite = default;
    public string[] introduction = new string[1];
}