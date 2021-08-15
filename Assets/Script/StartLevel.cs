using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartLevel : MonoBehaviour
{
    //do something on start
    [SerializeField] private UnityEvent onStart;
    [SerializeField] private UnityEvent onEnable;
    private void Start()
    {
        onStart?.Invoke();
    }
    private void OnEnable()
    {
        onEnable?.Invoke();
    }
}
