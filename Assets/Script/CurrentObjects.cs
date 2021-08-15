using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentObjects : MonoBehaviour
{
    //here we set and save all symbols on current level
    public List<ObjectToSpawn> currentObjects = new List<ObjectToSpawn>();
    public void AddToCurrentObjects(ObjectToSpawn OTS)
    {
        currentObjects.Add(OTS);
    }
    public ObjectToSpawn ChooseObject()
    {

        int index = Random.Range(0, currentObjects.Count);
        Debug.Log(index);
        return currentObjects[index];
    }
    public void Reset()
    {
        currentObjects = new List<ObjectToSpawn>();
    }
}
