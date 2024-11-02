using System.Collections;
using System.Collections.Generic;       
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject PlanetPrefab;
    public PlanetObj planetObject;
    public GameManager gameManager;

    
    // Start is called before the first frame update
    void Start()
    {
        //planetVal.planetName;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(gameManager.selectedPlanet == this)
            {
                gameManager.selectedPlanet = null;
            }
            else
            {
                gameManager.selectedPlanet = this;
            }
     
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
