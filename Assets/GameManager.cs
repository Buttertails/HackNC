using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Planet selectedPlanet;
    private PointerEventData pointerEventData;
    private EventSystem eventSystem;
    public TextMeshProUGUI planetNameText;
    public GameObject Panel;
    public GameObject ColonyPanel;
    public GameObject DevelopmentPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.position = Input.mousePosition;
        }

        if(selectedPlanet != null) 
        {
            planetNameText.text = selectedPlanet.planetObject.planetName;
            Panel.SetActive(true);
        }
        else
        {
            Panel.SetActive(false);
        }
    }

    public void ColonyButton()
    {
        if (ColonyPanel.activeSelf == false)
        {
            ColonyPanel.SetActive(true);
        }
        else
        {
            ColonyPanel.SetActive(false);
        }
    }

    public void DevelopmentButton()
    {
        if (DevelopmentPanel.activeSelf == false)
        {
            DevelopmentPanel.SetActive(true);
        }
        else
        {
            DevelopmentPanel.SetActive(false);
        }
    }
}
