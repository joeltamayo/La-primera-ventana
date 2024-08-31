using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCreditos : MonoBehaviour
{
    public void abrirCreditos(){
        SceneManager.LoadScene(3);
    }
}
