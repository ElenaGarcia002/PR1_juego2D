using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FuegoScript : MonoBehaviour
{

    public float speedBala = 2.0f;

    GameObject personaje;

    bool miraDerechaFuego;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        miraDerechaFuego = personaje.GetComponent<MovPersonaje>().miraDerecha;
      
    }

    // Update is called once per frame
    void Update()
    {
    
        if(miraDerechaFuego == true){
            transform.Translate(speedBala*Time.deltaTime, 0, 0);
        }else{
            transform.Translate((speedBala*Time.deltaTime)*-1, 0, 0);
        }
        
        
         
    }


    void OnTriggerEnter2D(Collider2D col){
        Debug.Log(col.gameObject.name);
    }
}
