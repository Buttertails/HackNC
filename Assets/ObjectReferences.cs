using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReferences : MonoBehaviour
{
    public List<ResourceObject> resourceObjects = new List<ResourceObject>();
    public Dictionary<string, ResourceObject> resourceObjectReferences = new Dictionary<string, ResourceObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (ResourceObject i in resourceObjects)
        {
            resourceObjectReferences.Add(i.name, i);
            Debug.Log(i.name);
            //ResourceObject resourceObject = new ResourceObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public ResourceObject RetriveResourceObject(string name)
    {
        //Debug.Log(resourceObjectReferences[name]);
        if (resourceObjectReferences.ContainsKey(name))
        {
            return resourceObjectReferences[name];
        }
        else
        {
            throw new System.Exception("Key did not return a resource object");
        }
        //return resourceObjects;
    }
    */
}
