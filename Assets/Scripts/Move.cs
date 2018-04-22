using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour {

    public float speed = 4f;
    public NavMeshAgent nav;
    private GraphicRaycaster gr;
    private PointerEventData pointerEventData;
    private List<RaycastResult> graphicsRaycasters;
    private List<string> tagsList;
    // Use this for initialization
    void Start()
    {
        pointerEventData = new PointerEventData(GetComponent<EventSystem>());
        gr = gameObject.GetComponent<GraphicRaycaster>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /* if(Input.GetMouseButtonUp(0))
         {
             Vector3 mousePos = Input.mousePosition;
             pointerEventData.position = mousePos;
             MoveObj(mousePos);
         }*/

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            graphicsRaycasters = new List<RaycastResult>();
            tagsList = new List<string>();

            pointerEventData.position = mousePosition;
            gr.Raycast(pointerEventData, graphicsRaycasters);

            Debug.Log(graphicsRaycasters.Count);

            foreach (RaycastResult r in graphicsRaycasters)
            {
                tagsList.Add(r.gameObject.tag);
            }

            if (!tagsList.Contains("Button"))
            {
                MoveObj(mousePosition);
            }
        }
    }

    void MoveObj(Vector3 mousePos)
    {

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit r;
        if (Physics.Raycast(ray, out r, 500))
        {
           
            Debug.Log(r.transform.tag);
            Debug.Log(r.collider.tag);
            
            nav.speed = speed;
            nav.SetDestination(r.point);
        }
    }

}
