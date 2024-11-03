using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet Object", menuName = "ScriptableObject/Planet")]
public class PlanetObj : ScriptableObject
{
    public string planetName;
    public string resourceType;
}
