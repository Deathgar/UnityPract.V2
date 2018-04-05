using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleButtons : MonoBehaviour {
    public Canvas canvas;

    private void Start()
    {
        canvas.enabled = false;
    }

    public void EnableCanvas()
    {
        canvas.enabled = true;
        gameObject.SetActive(false);
    }

    public void DisableCanvas()
    {
        canvas.enabled = false;
        gameObject.SetActive(true);
    }
}
