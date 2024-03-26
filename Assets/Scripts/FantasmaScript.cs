using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{
    Vector3 positionInicial;

    public float distanciaAtaque = 3;
    public float velocidadFanstasma = 10.0f;

    GameObject personaje;
    
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        positionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //Distancia

        float distancia = Vector3.Distance(personaje.transform.position, this.transform.position); 
        Debug.Log("Distancia: "+distancia); 

        float velocidadFinal = velocidadFanstasma * Time.deltaTime;
        //Ataque
         if(distancia <= distanciaAtaque){
            Debug.Log("ATAQUEEEEE: ");
             transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position,velocidadFinal);
        }else{
            transform.position = Vector3.MoveTowards(transform.position, positionInicial, velocidadFinal);
        }
    }
}
