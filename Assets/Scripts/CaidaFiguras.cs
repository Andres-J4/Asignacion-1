using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaFiguras : MonoBehaviour
{
    [Header("Objeto")]
    public GameObject prefab;

    [Header("Escena")]
    public float minX;
    public float maxiX;
    public float timerMax;
    public float timerMin;
    public float ejeY;
    private float timer;

    [Header("Figuras")]
    public Sprite[] sprites;




    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(timerMin, timerMax);
        InvokeRepeating("Caida", timer, timer);
        Destroy(gameObject, GameObject.Find("Tiempo").transform.GetComponent<Tiempo>().tiempoJuego);


    }

    // Funcion para generar aleatoriamente las formas geometricas
    private void Caida()
    {
        GameObject rango = Instantiate(prefab);

        rango.transform.position = new Vector2(
            Random.Range(minX, maxiX), ejeY
        );

        Sprite geo = sprites[0];

        rango.GetComponent<SpriteRenderer>().sprite = geo;

    }


}
