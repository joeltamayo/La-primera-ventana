using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnlaces : MonoBehaviour
{
    public void abrirEnlace(string link) {
        Application.OpenURL(link);
    }
}
