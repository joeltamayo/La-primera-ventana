using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladordeColision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll){
        Debug.Log("La antorcha toco la gogata");
    }
}
