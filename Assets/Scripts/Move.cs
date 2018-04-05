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
    public GameObject buttonRgb;
    public GameObject buttonFigures;
    public RaiCasterCanvases grRgb;
    public RaiCasterCanvases grFigures;

    // Use this for initialization
    void Start () {
        pointerEventData = new PointerEventData(GetComponent<EventSystem>());
        gr = GetComponent<GraphicRaycaster>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
       
        

        if(Input.GetMouseButtonUp(0))
        {

            Vector3 mousePos = Input.mousePosition;

            List<RaycastResult> graphicsRaycasters = new List<RaycastResult>();

            pointerEventData.position = mousePos;
            gr.Raycast(pointerEventData, graphicsRaycasters);
           // Debug.Log(graphicsRaycasters.Count);

            if (grRgb.isEmpty(mousePos) && grFigures.isEmpty(mousePos))
            {
                if(graphicsRaycasters.Count == 0)
                {
                    if (grRgb.Check(mousePos).Equals("noth") && grFigures.Check(mousePos).Equals("noth"))
                    {
                        Deactivate();
                        MoveObj(mousePos);
                    }
                }
                else
                {
                    if (!graphicsRaycasters[0].gameObject.tag.Equals("Button"))
                    {
                        MoveObj(mousePos);
                    }
                }
               
               // MoveObj(mousePos);
               
            }
            else
            {
                //Debug.Log("GR " +  graphicsRaycasters[0].gameObject.tag);
                //Debug.Log("RGB " + grRgb.Check(mousePos));
               // Debug.Log("FIG " + grFigures.Check(mousePos));
               
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
    
    void Deactivate()
    {
        buttonRgb.GetComponent<VisibleButtons>().DisableCanvas();
        buttonFigures.GetComponent<VisibleButtons>().DisableCanvas();

    }

}
