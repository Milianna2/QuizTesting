using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    [SerializeField] private GameObject go;
    [SerializeField] private bool active;
    public void SetActiveGO()
    {
        go.SetActive(active);
    }
}
