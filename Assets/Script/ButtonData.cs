using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour
    //here we save data for each icon
{
    private ObjectToSpawn buttonData;
    public void SetDataToButton(ObjectToSpawn bd)
    {
        buttonData = bd;
    }
    public ObjectToSpawn GetDataOfButton()
    {
        return buttonData;
    }
}
