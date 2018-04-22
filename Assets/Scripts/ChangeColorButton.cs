using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorButton : MonoBehaviour {
    public Color color;
    public MeshRenderer meshRend;

    public void Change()
    {
        meshRend.material.color = color;
    }
}
