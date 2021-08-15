using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTheAnswer : MonoBehaviour
{
    //set what we do right answer and what on wrong
    [SerializeField] private UnityEvent onRight;
    [SerializeField] private UnityEvent onWrong;
    private ButtonData bd;
    private void Awake()
    {
        bd = GetComponent<ButtonData>();
    }

    public void CheckAnswer()
    {
        if (bd.GetDataOfButton().chosen)
        {
            onRight?.Invoke();
        }
        else
        {
            onWrong?.Invoke();
        }
    }
}
