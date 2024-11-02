using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet Object", menuName = "ScriptableObject/Planet")]
public class PlanetObj : ScriptableObject
{
    public string planetName;
    public string resourceType;
    // Start is called before the first frame update
    private void Reset()
    {
        
    }
}