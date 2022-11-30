using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Taryn : MonoBehaviour
{
    public float speed;
    Animator anim;
    public int damageEnimes;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
    float inputAxis = Input.GetAxis("Horizontal");
       if(Input.GetButtonDown("Fire3"))
        {
            Vector3 Movimento = new Vector3(15f,0f,0f);
            transform.position += 3*Movimento * Time.deltaTime * speed;
            anim.SetBool("Dash",true); 
        }
        else
        {
            anim.SetBool("Dash",false); 
        }

         if(Input.GetButtonDown("Fire3") && inputAxis < 0)
        {
            Vector3 Movimento = new Vector3(-15f,0f,0f);
            transform.position += 3*Movimento * Time.deltaTime * speed;
            anim.SetBool("Dash",true); 
        }
        else
        {
            anim.SetBool("Dash",false); 
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<Life_God>().Dano(damageEnimes);
        }
    }
}
