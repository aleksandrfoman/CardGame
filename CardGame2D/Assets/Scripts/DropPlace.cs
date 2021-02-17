using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum FieldType
{
    SELF_HAND,
    SELF_FIELD,
    ENEMY_HAND,
    ENEMY_FIELD
}


public class DropPlace : MonoBehaviour,IDropHandler,IPointerEnterHandler,IPointerExitHandler
{
    public FieldType Type;
    
    public void OnDrop(PointerEventData eventData)
    {
        if(Type != FieldType.SELF_FIELD)
            return;

        CardMovementScr card = eventData.pointerDrag.GetComponent<CardMovementScr>();
        if (card)
        {
            card.defaultParent = transform;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null || Type == FieldType.ENEMY_FIELD || Type==FieldType.ENEMY_HAND)
        {
            return;
        }
        CardMovementScr card = eventData.pointerDrag.GetComponent<CardMovementScr>();
        if (card)
        {
            card.defaultTempCardParent = transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
        {
            return;
        }
        CardMovementScr card = eventData.pointerDrag.GetComponent<CardMovementScr>();
        if (card&&card.defaultTempCardParent == transform)
        {
            card.defaultTempCardParent = card.defaultParent;
        }

    }
}
