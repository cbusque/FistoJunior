using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class drop : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {

    }


    public void OnDrop(PointerEventData eventData)
    {
        drag d = eventData.pointerDrag.GetComponent<drag>();
        if (d != null) {
            if (gameObject.GetComponent<member>().getPiece() == eventData.pointerDrag.GetComponent<member>().getPiece())
            {
                Debug.Log(this.transform.name);
                d.setParentOrigin(this.transform);
                eventData.pointerDrag.GetComponent<member>().setPlaced(true);
                Debug.Log(eventData.pointerDrag.GetComponent<member>().getPlaced());
                


            }
        }
                   
     }

    public void OnPointerExit(PointerEventData eventData)
    {

    }



}
