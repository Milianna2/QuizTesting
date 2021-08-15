using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//We disable buttons that we marked
public class DisableButtons : MonoBehaviour
{
    public GameObject[] buttons;
    private void FindButtons()
    {
        buttons = GameObject.FindGameObjectsWithTag("Button");
    }
    public void Disable()
    {
        FindButtons();
        foreach (GameObject go in buttons)
        {
            go.gameObject.SetActive(false);
        }
    }
}
