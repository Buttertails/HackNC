using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;

public class LocalMarket : MonoBehaviour
{
    public ObjectReferences objectReferences;
    public GameObject marketContainer1;
    public GameObject marketContainerPrefab;
    public GameObject marketContainer2;
    public GameObject marketContainer3;
    public List<GameObject> containers = new List<GameObject>();
    public TextMeshProUGUI resourceText;
    public ResourceObject resource;

    // Start is called before the first frame update
    void Start()
    {
        objectReferences = GameObject.Find("GameManager").GetComponent<ObjectReferences>();
        int positionCount = 0;
        foreach(ResourceObject i in objectReferences.resourceObjects)
        {
            //containers.Add(Instantiate(marketContainerPrefab));
            //containers[positionCount].GetComponent<ResourceContainer>().resourceContainer = objectReferences.RetriveResourceObject(objectReferences.resourceObjects[positionCount].resourceName);
            positionCount++;
        }
        resourceText.text = resource.resourceName;
    }

    // Update is called once per frame
    void Update()
    {
        //objectReferences.RetriveResourceObject(name);
    }

    public void BuyButton()
    {
       
    }
}
