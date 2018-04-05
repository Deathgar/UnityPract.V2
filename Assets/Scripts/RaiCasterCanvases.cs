using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RaiCasterCanvases : MonoBehaviour {

    public string Check(Vector3 mousePos)
    {
        PointerEventData pointerEventData = new PointerEventData(GetComponent<EventSystem>()); ;
        List<RaycastResult> graphicsRaycasters = new List<RaycastResult>();
        pointerEventData.position = mousePos;
        GetComponent<GraphicRaycaster>().Raycast(pointerEventData, graphicsRaycasters);

        //Debug.Log(graphicsRaycasters[0].gameObject.tag);

        if (graphicsRaycasters.Count == 0)
        {
            return "noth";
        }
        else
        {
            return graphicsRaycasters[0].gameObject.tag;
        }
    }

    public bool isEmpty(Vector3 mousePos)
    {
        PointerEventData pointerEventData = new PointerEventData(GetComponent<EventSystem>()); ;
        List<RaycastResult> graphicsRaycasters = new List<RaycastResult>();
        pointerEventData.position = mousePos;
        GetComponent<GraphicRaycaster>().Raycast(pointerEventData, graphicsRaycasters);

        if(graphicsRaycasters.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
