using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//this function runs on animation event in the midle of fadeInOut
public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private UnityEvent onLoading;
    public void OnLoading()
    {
        onLoading?.Invoke();
    }
}
