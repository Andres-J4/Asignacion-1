using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    [Header("Duracion")]
    public float tiempoJuego;
    public GameObject punto;
    public GameObject tiempo;
    public GameObject final;
    private float timeIn = 0;
    // Start is called before the first frame update
    void Start()
    {
        TiempoInit = 0;
    }

    public float TiempoInit
    {
        get { return timeIn; }
        set
        {
            timeIn = value;
            GetComponent<Text>().text = "Tiempo: " + timeIn;
        }
    }

    void Update()
    {
        tiempoJuego -= Time.deltaTime;

        if (tiempoJuego < 0)
        {
            Text textoFinal = final.GetComponentInChildren<Text>();


            int puntoFinal = GameObject.Find("Puntuacion").GetComponent<Puntos>().PuntosInit;

            textoFinal.text = string.Format(textoFinal.text, puntoFinal);

            punto.SetActive(false);
            tiempo.SetActive(false);
            final.SetActive(true);

            gameObject.SetActive(false);
        }
        else
        {

            GameObject.Find("Tiempo").transform.GetComponent<Tiempo>().TiempoInit = Mathf.Round(tiempoJuego);
        }
    }
}
