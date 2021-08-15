using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CurrentLevel : MonoBehaviour
{
    //Here we switch from level to level
    //disable one enable another
    [SerializeField] private GameObject[] levels;
    [SerializeField] private UnityEvent onFinishedAllLevels;
    private int length;
    private int index;
    private void Awake()
    {
        index = 0;
        length = levels.Length;
    }
    public void NextLevel()
    {
        if (index < length - 1)
        {
            Destroy(levels[index]);
            index++;
            levels[index].SetActive(true);
        }
        else onFinishedAllLevels?.Invoke();
    }
}
