using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleButtons : MonoBehaviour {
    public Button first;
    public Button second;
    public Button third;

    private void Start()
    {
        first.gameObject.active = false;
        second.gameObject.active = false;
        third.gameObject.active = false;
    }

    public void Change()
    {
        if(!first.gameObject.active)
        {
            Enable();
        }
        else
        {
            Disable();
        }
    }

    private void Enable()
    {
        first.gameObject.active = true;
        second.gameObject.active = true;
        third.gameObject.active = true;
    }

    private void Disable()
    {
        first.gameObject.active = false;
        second.gameObject.active = false;
        third.gameObject.active = false;
    }
}
