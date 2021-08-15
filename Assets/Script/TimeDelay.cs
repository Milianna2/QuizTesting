using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeDelay : MonoBehaviour
{
    //cooldown component, do something after cooldown
    [SerializeField] private float seconds;
    [SerializeField] private UnityEvent OnAfterCoolDownd;
    public void StartCoolDown()
    {
        StartCoroutine(something());
    }
    IEnumerator something()
    {
        yield return new WaitForSeconds(seconds);
        OnAfterCoolDownd?.Invoke();
    }
}
