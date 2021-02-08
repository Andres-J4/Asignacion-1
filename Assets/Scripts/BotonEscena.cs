using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonEscena : MonoBehaviour
{
    // Funcion para cambiar de escena
    public void CambiarEscena(string name)
    {
        SceneManager.LoadScene(name);
    }
}
