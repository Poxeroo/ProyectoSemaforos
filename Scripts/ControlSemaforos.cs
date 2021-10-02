using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSemaforos : MonoBehaviour
{
    [Range(0f,10f)]
    public float tiempoCorrutina = 5f;

    public List <GameObject> SemaforoNorte;
    public List <GameObject> SemaforoSur;
    public List <GameObject> SemaforoEste;
    public List <GameObject> SemaforoOeste;             
    public List<GameObject> Stops;
    public List<GameObject> Siga;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ControladorSemaforos(tiempoCorrutina));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SemaforoNorteSurRojo()
    {
        SemaforoNorte[0].SetActive(true); //rojo
        SemaforoNorte[1].SetActive(false);  // amarillo
        SemaforoNorte[2].SetActive(false); //verde

        SemaforoSur[0].SetActive(true); //rojo
        SemaforoSur[1].SetActive(false);  // amarillo
        SemaforoSur[2].SetActive(false); //verde

        Siga[0].SetActive(false);
        Siga[1].SetActive(false);

        Stops[0].SetActive(true);
        Stops[1].SetActive(true);

    }

    void SemaforoNorteSurAmarillo()
    {
        SemaforoNorte[0].SetActive(false); //rojo
        SemaforoNorte[1].SetActive(true);  // amarillo
        SemaforoNorte[2].SetActive(false); //verde

        SemaforoSur[0].SetActive(false); //rojo
        SemaforoSur[1].SetActive(true);  // amarillo
        SemaforoSur[2].SetActive(false); //verde

        Siga[0].SetActive(false);
        Siga[1].SetActive(false);

        Stops[0].SetActive(true);
        Stops[1].SetActive(true);

    }

    void SemaforoNorteSurVerde()
    {
        SemaforoNorte[0].SetActive(false); //rojo
        SemaforoNorte[1].SetActive(false);  // amarillo
        SemaforoNorte[2].SetActive(true); //verde

        SemaforoSur[0].SetActive(false); //rojo
        SemaforoSur[1].SetActive(false);  // amarillo
        SemaforoSur[2].SetActive(true); //verde

        Siga[0].SetActive(true);
        Siga[1].SetActive(true);

        Stops[0].SetActive(false);
        Stops[1].SetActive(false);
    }

    void SemaforoEsteOesteRojo()
    {
        SemaforoOeste[0].SetActive(true); //rojo
        SemaforoOeste[1].SetActive(false);  // amarillo
        SemaforoOeste[2].SetActive(false); //verde

        SemaforoEste[0].SetActive(true); //rojo
        SemaforoEste[1].SetActive(false);  // amarillo
        SemaforoEste[2].SetActive(false); //verde

        Siga[2].SetActive(false);
        Siga[3].SetActive(false);

        Stops[2].SetActive(true);
        Stops[3].SetActive(true);

    }

    void SemaforoEsteOesteAmarillo()
    {
        SemaforoOeste[0].SetActive(false); //rojo
        SemaforoOeste[1].SetActive(true);  // amarillo
        SemaforoOeste[2].SetActive(false); //verde

        SemaforoEste[0].SetActive(false); //rojo
        SemaforoEste[1].SetActive(true);  // amarillo
        SemaforoEste[2].SetActive(false); //verde

        Siga[2].SetActive(false);
        Siga[3].SetActive(false);

        Stops[2].SetActive(true);
        Stops[3].SetActive(true);
    }

    void SemaforoEsteOesteVerde()
    {
        SemaforoOeste[0].SetActive(false); //rojo
        SemaforoOeste[1].SetActive(false);  // amarillo
        SemaforoOeste[2].SetActive(true); //verde

        SemaforoEste[0].SetActive(false); //rojo
        SemaforoEste[1].SetActive(false);  // amarillo
        SemaforoEste[2].SetActive(true); //verde

        Siga[2].SetActive(true);
        Siga[3].SetActive(true);

        Stops[2].SetActive(false);
        Stops[3].SetActive(false);
        
    }

    IEnumerator ControladorSemaforos(float tiempo)
    {
        while (true)
        {
            SemaforoNorteSurRojo();
            SemaforoEsteOesteVerde();
            yield return new WaitForSeconds(tiempo);
            SemaforoEsteOesteAmarillo();
            yield return new WaitForSeconds(3f);
            SemaforoEsteOesteRojo();
            SemaforoNorteSurVerde();
            yield return new WaitForSeconds(tiempo);
            SemaforoNorteSurAmarillo();
            yield return new WaitForSeconds(3f);
        }
    }
}
