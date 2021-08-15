using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSet : MonoBehaviour
{
    //Here we choose which set of objects we want to show (letters, numbers or something else)
    [SerializeField] public SetOfObjects[] objects;
    public SetOfObjects currentSet;
    private void Awake()
    {
        ChooseRandomSet();
    }
    public void ChooseRandomSet()
    {
        int randObj = Random.Range(0, objects.Length);
        currentSet = objects[randObj];
    }
}
