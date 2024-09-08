using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class movimientoElementos : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject objetoMovible;
    Vector3 posicionInicial;
    float distanciaZHaciaCamara;
     Vector3  posicionActual;
     
     public void OnBeginDrag(PointerEventData eventDatai){
        objetoMovible = gameObject;
        posicionInicial = transform.position;
        distanciaZHaciaCamara = math.abs(posicionInicial.z -Camera.main.transform.position.z);
        posicionActual = posicionInicial - Camera.main.ScreenToWorldPoint
            (new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanciaZHaciaCamara));
     }

     public void OnDrag(PointerEventData eventDatai){
        if(Input.touchCount>1)
        return;

        transform.position = Camera.main.ScreenToWorldPoint
            (new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanciaZHaciaCamara)) + posicionActual;
     }

     public void OnEndDrag(PointerEventData eventDatai){
        objetoMovible = null;
        posicionActual = Vector3.zero;
     }
}
