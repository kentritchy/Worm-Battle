using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftKey : MonoBehaviour, IPointerUpHandler, IPointerDownHandler

{
    [HideInInspector]
    public bool Pressed;
    public PlayerController playerController;


    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
