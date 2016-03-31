using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler {
    //attribut
   private Transform parentToReturnTo = null;

    private float x = 0;
    private float y = 0;
    private float z = 0;


    public Transform getParentOrigin() {
        return parentToReturnTo;
    }

    public void setParentOrigin(Transform canevas) {
        parentToReturnTo = canevas;
    }



    public void OnBeginDrag(PointerEventData eventData)
    {
        
            Debug.Log(gameObject.transform.parent);

           parentToReturnTo = this.transform.parent;
           this.transform.SetParent(this.transform.parent.parent);
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

        GetComponent<CanvasGroup>().blocksRaycasts = false;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("OnDrag");
        this.transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        Debug.Log("OnEndDrag");
        this.transform.position = eventData.position;
        this.transform.SetParent(parentToReturnTo);
       

        GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (eventData.pointerDrag.GetComponent<member>().getPlaced() == true)
        {
            Debug.Log(eventData.pointerDrag.GetComponent<member>().getPlaced());
            eventData.pointerDrag.GetComponent<drag>().enabled = false;
        }
        else this.transform.position = new Vector3(x, y, z);

    }







}
