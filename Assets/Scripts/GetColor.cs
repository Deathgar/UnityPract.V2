using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetColor : MonoBehaviour {
    private List<RaycastResult> graphicsRaycasters;
    private GraphicRaycaster gr;
    private PointerEventData pointerEventData;
    private List<string> tagsList;
    // Use this for initialization
    void Start () {
        pointerEventData = new PointerEventData(GetComponent<EventSystem>());        
        gr = gameObject.GetComponent<GraphicRaycaster>();
    }

    // Update is called once per frame
    private void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            graphicsRaycasters = new List<RaycastResult>();
            tagsList = new List<string>();

            pointerEventData.position = Input.mousePosition;
            gr.Raycast(pointerEventData, graphicsRaycasters);

            Debug.Log(graphicsRaycasters.Count);

            foreach(RaycastResult r in graphicsRaycasters)
            {
                tagsList.Add(r.gameObject.tag);
                Debug.Log(r.gameObject.tag);
            }


        }
    }
}
