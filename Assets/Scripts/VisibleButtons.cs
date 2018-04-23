using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleButtons : MonoBehaviour {
    public Button firstDef;
    public Button secondDef;
    public Button thirdDef;

    private void Start()
    {
        firstDef.gameObject.active = false;
        secondDef.gameObject.active = false;
        thirdDef.gameObject.active = false;



    }

    public void Change()
    {
        if(!firstDef.gameObject.active)
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
        firstDef.gameObject.active = true;
        secondDef.gameObject.active = true;
        thirdDef.gameObject.active = true;

    }

    private void Disable()
    {
        firstDef.gameObject.active = false;
        secondDef.gameObject.active = false;
        thirdDef.gameObject.active = false;

    }

}
