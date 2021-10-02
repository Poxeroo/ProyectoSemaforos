using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBotones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarVelocidadLento()
    {
            Time.timeScale = 0.5f;
    }

    public void CambiarVelocidadNormal()
    {
            Time.timeScale = 1f;
    }

    public void CambiarVelocidadRapido()
    {
            Time.timeScale = 10f;
    }
}
