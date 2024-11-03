using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Resource Object", menuName = "ScriptableObject/Resources")]

public class ResourceObject : ScriptableObject
{
    public string resourceName;
    public int resourceQuantity;
    public float price;
    public float basePrice;
    public float elasticity;
}
