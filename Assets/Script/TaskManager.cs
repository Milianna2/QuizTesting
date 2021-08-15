using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    //sets the answer and text for task
    private ObjectToSpawn trueAnswer;
    private CurrentObjects currentObjects;

    private Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        currentObjects = FindObjectOfType<CurrentObjects>();
    }
    public void GetRandomLetter()
    {
        trueAnswer = currentObjects.ChooseObject();
        trueAnswer.chosen = true;
        text.text = "Find " + trueAnswer.name;
    }
}
