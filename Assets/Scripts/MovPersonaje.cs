using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class MovPersonaje : MonoBehaviour
{

    public float multiplicadorVelocidad = 4;

    Rigidbody2D rb;
    SpriteRenderer sr;

    Animator animatorController;

    public float multiplicadorSalto = 5;

    bool puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
        animatorController = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO
        float mov = Input.GetAxis("Horizontal") * multiplicadorVelocidad * Time.deltaTime;
        //transform.position = new Vector3(transform.position.x+mov, transform.position.y, transform.position.z); 

        transform.Translate(mov, 0, 0);

        //Flip personaje <-
         if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
                sr.flipX = true;
                animatorController.SetBool("activaCamina", true);
         }
        //Flip personaje >-
          if (Input.GetKeyDown(KeyCode.D)){
                sr.flipX = false;
                animatorController.SetBool("activaCamina", true);
         }
        //quieto
         if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)){
            animatorController.SetBool("activaCamina", false);
         }
        //Rayo
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f);

        if(hit){
            Debug.DrawRay(transform.position, Vector2.down, Color.magenta);
            if (hit.collider.name == "Grid" || hit.collider.name == "Square"){
            puedoSaltar = true;
        }else{
            puedoSaltar = false;
        }


        //SALTO
        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar==true){
            rb.AddForce(new Vector2(0,multiplicadorSalto), ForceMode2D.Impulse);
            Debug.Log("Salto");
        }
        
       
    }
    }
}
