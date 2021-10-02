using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMotorOeste : MonoBehaviour
{
    //esto es para ingreasar que es lo que generare
    public GameObject MotorOeste;

    //el tiempo de generacion del motor sur
    [Range(1f, 10f)]
    public float TiempoGeneracion = 2f;
    [Range(0f, 10f)]
    public float TiempoReaccion = 2f;

    // Start is called before the first frame update
    void Start()
    {
        IniciarGeneradorOeste();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateMotorOeste()
    {
        //instacion lo que voy a generar y donde lo generare 
        Instantiate(MotorOeste, transform.position, Quaternion.identity); // ni puta idea de que es el quaternion

    }
    //inicio la invocacion
    public void IniciarGeneradorOeste()
    {
        Debug.Log(".....1");
        InvokeRepeating("CreateMotorOeste", TiempoReaccion, TiempoGeneracion);

    }
}
