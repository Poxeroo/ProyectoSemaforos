using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMotorOeste : MonoBehaviour
{
    [Range(0f, 10f)]
    public float VelocidadMotorOeste = 5f;

    private Rigidbody2D rigidB2D;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidB2D = GetComponent<Rigidbody2D>();
        rigidB2D.velocity = Vector2.right * VelocidadMotorOeste;// el velocity es como se reconoce la velocidad de rogidbody2d 
       
    }

    // Update is called once per frame
    void Update()
    {

    }
  
    void OnTriggerEnter2D(Collider2D colision)//sobre escribimos esta funcion osea que obligatoria mente se debe llamar asi
    {
        //no obligatoria mente este se debe destruir pero se hace de buena practicar para no explotar las PCs
        if (colision.gameObject.tag == "Destructor")
        {
            Destroy(gameObject);//Destruyo al enemigo al chocar con el box collider colocado atras del personaje
        }

        if (colision.gameObject.tag == "Siga")
        {
            rigidB2D.velocity = Vector2.right * VelocidadMotorOeste;
        }

        if (colision.gameObject.tag == "Stop")
        {
            rigidB2D.velocity = Vector2.right * 0;
        } 

      
    }
}
