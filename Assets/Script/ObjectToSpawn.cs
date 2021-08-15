using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Create classes for sets of objects and objects inside
[System.Serializable]
public class ObjectToSpawn
{
    [SerializeField] public Sprite sprite;
    [SerializeField] public string name;
    //was it in the level
    public bool existed;
    //was it in in session
    public bool chosen;
}
[System.Serializable]
public class SetOfObjects
{
    [SerializeField] public string name;
    [SerializeField] public ObjectToSpawn[] objects;
}
