using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WealthTracker : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip errorSound;
    public int currency;
    public int iron;
    public int nitrogen;
    public int wood;
    public TextMeshProUGUI currencyText;
    public TextMeshProUGUI ironText;
    public TextMeshProUGUI nitrogenText;
    public TextMeshProUGUI woodText;
    public TextMeshProUGUI insufficientResourceText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("Spaceship").GetComponent<AudioSource>();
        currency = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = "Currency: " + currency;
        ironText.text = "Iron: " + iron;
        nitrogenText.text = "Wood: " + wood;
    }

    public void SellResource(string resourceType, int resourceAmount)
    {
        if(resourceType == "Iron")
        {
            if(resourceAmount > iron)
            {
                StartCoroutine(NotEnoughResources(resourceType));
            }
            else
            {
                iron += resourceAmount;
            }
        }
        else if(resourceType == "Nitrogen")
        {
            if(resourceAmount > nitrogen)
            {
                StartCoroutine(NotEnoughResources(resourceType));
            }
            else
            {
                nitrogen += resourceAmount;
            }
        }
        else if(resourceType == "Wood")
        {
            if(resourceAmount > wood)
            {
                StartCoroutine(NotEnoughResources(resourceType));
            }
            else
            {
                wood += resourceAmount;
            }
        }
    }
    public void BuyResource(string resourceType, int resourceAmount)
    {
        if(resourceType == "Iron")
        {
            if(resourceAmount > iron)
            {
                StartCoroutine(NotEnoughResources(resourceType));
            }
            else
            {
                iron -= resourceAmount;
            }
        }
        else if(resourceType == "Nitrogen")
        {
            if(resourceAmount > nitrogen)
            {
                StartCoroutine(NotEnoughResources(resourceType));
            }
            else
            {
                nitrogen -= resourceAmount;
            }
        }
        else if(resourceType == "Wood")
        {
            if(resourceAmount > wood)
            {
                StartCoroutine(NotEnoughResources(resourceType));
            }
            else
            {
                wood -= resourceAmount;
            }
        }
    }

    IEnumerator NotEnoughResources(string resource)
    {
        insufficientResourceText.text = "Not Enough " + resource + "!";
        audioSource.clip = errorSound;
        audioSource.Play();
        yield return new WaitForSeconds(1);
        insufficientResourceText.text = "";
    }
}
