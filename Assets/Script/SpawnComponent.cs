using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    //It spawns given object to the position we wanted
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform target;
    [ContextMenu("Spawn")]

    public void Spawn()
    {
        var instantiate = Instantiate(prefab, target);
        instantiate.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
