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
    public GameObject LocalMarketPanel;

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
            ColonyPanel.SetActive(false);
            DevelopmentPanel.SetActive(false);
            LocalMarketPanel.SetActive(false);
        }
    }

    public void ColonyButton()
    {
        if (ColonyPanel.activeSelf == false)
        {
            ColonyPanel.SetActive(true);
            DevelopmentPanel.SetActive(false);
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
            ColonyPanel.SetActive(false);
        }
        else
        {
            DevelopmentPanel.SetActive(false);
        }
    }

    public void LocalMarketButton()
    {
        if(LocalMarketPanel.activeSelf == false)
        {
            LocalMarketPanel.SetActive(true);
        }
        else
        {
            LocalMarketPanel.SetActive(false); 
        }
    }
}
