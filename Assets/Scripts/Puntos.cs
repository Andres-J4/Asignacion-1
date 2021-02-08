using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{

    private int puntuacion = 0;
    // Start is called before the first frame update
    void Start()
    {
        PuntosInit = 0;
    }

    public int PuntosInit{
        get { return puntuacion; }
        set {
            puntuacion = value;
            GetComponent<Text>().text = "Puntos: " + puntuacion;
        }
    }
}
