using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Parafax : MonoBehaviour
{

    GameObject personaje;

    public float parallaxSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
       personaje = GameObject.Find("Personaje"); 
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = personaje.transform.position;

       transform.position = new Vector3(Camera.main.transform.position.x*parallaxSpeed,//x
                                        Camera.main.transform.position.y*parallaxSpeed,//y
                                        0
                                        );
       // transform.position = new Vector3(Camera.main.transform.position.x/paralaxSpeed, Camera.main.transformmposition,y/paralaxSpeed, 0) 
    }
}
