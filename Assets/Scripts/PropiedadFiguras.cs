using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropiedadFiguras : MonoBehaviour
{

    [Header("Propiedades")]
    public float uptime;
    public float minXvel;
    public float maxiXvel;
    public float minYvel;
    public float maxiYvel;
    public int valor;

    // Start is called before the first frame update
    void Start()
    {
        float tiempoVel = GameObject.Find("Tiempo").transform.GetComponent<Tiempo>().tiempoJuego;


        if (tiempoVel < 30)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minXvel, maxiXvel),
            Random.Range(minYvel * 5, maxiYvel * 5)
            );
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minXvel, maxiXvel),
            Random.Range(minYvel, maxiYvel)
        );
        }


        Destroy(gameObject, uptime);

    }


    void OnMouseDown()
    {
        Destroy(gameObject);
        GameObject.Find("Puntuacion").transform.GetComponent<Puntos>().PuntosInit += valor;
    }

}
