using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonConfiguracion : MonoBehaviour
{
    public void abrirConfiguracion(){
        SceneManager.LoadScene(2);
    }
}
