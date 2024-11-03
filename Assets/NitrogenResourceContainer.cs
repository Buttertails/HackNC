using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NitrogenResourceContainer : MonoBehaviour
{
    public TextMeshProUGUI submitButtonText;
    private WealthTracker wealthTracker;
    public AudioSource audioSource;
    public int resourceCount = 0;
    void Start()
    {
        audioSource = GameObject.Find("GameManager").GetComponent<AudioSource>();
        wealthTracker = GameObject.Find("GameManager").GetComponent<WealthTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (resourceCount == 0)
        {
            submitButtonText.text = "S";
        }
        else
        {
            submitButtonText.text = resourceCount.ToString();
        }

    }
    public void decrement()
    {
        resourceCount--;
        audioSource.Play();
    }

    public void increment()
    {
        resourceCount++;
        audioSource.Play();
    }

    public void submit()
    {
        if (resourceCount < 0)
        {
            wealthTracker.SellResource("Nitrogen", -1 * resourceCount);
        }
        else if (resourceCount > 0)
        {
            wealthTracker.BuyResource("Nitrogen", resourceCount);
        }
        audioSource.Play();
    }
}
