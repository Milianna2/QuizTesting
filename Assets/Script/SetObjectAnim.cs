using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectAnim : MonoBehaviour
{
    public Animator anim = new Animator();
    public void SetAnim()
    {
        Debug.Log("animation");
        anim = GetComponentInChildren<Animator>();
    }
    public void OnRight()
    {
        anim.SetTrigger("Right");
    }
    public void OnWrong()
    {
        anim.SetTrigger("Wrong");
    }
}
