using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceContainer : MonoBehaviour
{
    public ResourceObject resourceContainer;
    public TextMeshProUGUI submitButtonText;
    public TextMeshProUGUI resourceText;
    public int resourceCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        resourceText.text = resourceContainer.resourceName;
    }

    // Update is called once per frame
    void Update()
    {
        if(resourceCount == 0)
        {
            submitButtonText.text = "S";
        }
        else
        {
            submitButtonText.text = resourceCount.ToString();
        }
    }

    
}
