using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour
{

    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        
        Debug.Log(col.gameObject.name);

        if(col.gameObject.name == "Personaje"){

            _animator.SetBool("exitCoin", true);

            Destroy(this.gameObject, 1.0f);
        }
    }
}
