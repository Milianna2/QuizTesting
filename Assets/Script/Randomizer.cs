using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    //Here we choose rendom letter or number, spawn it, set the data about it and add it to list
    private ObjectToSpawn randObj;
    private RandomSet randSet;
    private SpriteRenderer sprite;
    private CurrentObjects currentObjects;
    private ButtonData bd;
    private void Awake()
    {
        randSet = FindObjectOfType<RandomSet>();
        sprite = GetComponent<SpriteRenderer>();
        currentObjects = FindObjectOfType<CurrentObjects>();
        randObj = new ObjectToSpawn();
        randObj.existed = true;
        //we call it once when it spawns and enables
        RandomObj();
    }
    private void RandomObj()
    {
        CheckEnoughObjects();
        //checks if we chose the object before
        while (randObj.existed || randObj.chosen) {
            int randIndex = Random.Range(0, randSet.currentSet.objects.Length);
            randObj = randSet.currentSet.objects[randIndex]; 
        }
        //setting data to list of objects, to icon and changing sprite
        randObj.existed = true;
        currentObjects.AddToCurrentObjects(randObj);
        sprite.sprite = randObj.sprite;
        bd = GetComponentInParent<ButtonData>();
        bd.SetDataToButton(randObj);
    }
    public void NextLevel()
    {
        //using for animation event, when animation ends, next level loads
        FindObjectOfType<CurrentLevel>().NextLevel();
    }
    private void CheckEnoughObjects()
    {
        //it checks if there are enought objects for slots
        //if not change the set
        int count = 0;
        foreach (ObjectToSpawn OTS in randSet.currentSet.objects)
        {
            if (OTS.chosen == false)
                count++;
        }
        if (count < 9)
        {
            randSet.ChooseRandomSet();
        }
    }
}
