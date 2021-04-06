using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clickevent : MonoBehaviour, IPointerDownHandler
{
    public Image selfImage;

    public void OnPointerDown(PointerEventData ped)
    {
        Debug.Log("aaa");
    }
}
