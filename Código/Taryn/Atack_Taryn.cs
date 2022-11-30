using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_Taryn : MonoBehaviour
{
    Animator anim;
    public bool sword;
    public int damageEnimes;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Atack", true);
            sword = false;
            
        }
        else
        {
            anim.SetBool("Atack",false);
            sword = true;
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


