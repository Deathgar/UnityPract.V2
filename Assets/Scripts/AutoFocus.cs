using UnityEngine;
using System.Collections;
using Vuforia;

public class AutoFocus : MonoBehaviour
{

    private bool mVuforiaStarted = false;

    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;

        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }

    private void StartAfterVuforia()
    {
        mVuforiaStarted = true;
        SetAutofocus();
    }


    private void SetAutofocus()
    {
        if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO))
        {
            Debug.Log("Autofocus set");
        }
        else
        {
            // never actually seen a device that doesn't support this, but just in case
            Debug.Log("this device doesn't support auto focus");
        }
    }
}