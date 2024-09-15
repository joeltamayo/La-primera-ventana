using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControladordeColision : MonoBehaviour
{
    public Animator animator; // Referencia al Animator

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("La antorcha toco la fogata");
        animator.SetBool("IsEncendida", true); // Cambia el parámetro a true
    }
}