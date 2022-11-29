using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    Animator anim;
    public bool atack;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision) //Componente de colisão na unity
    {
        if(collision.gameObject.tag == "Player") //Se Zeus collidir com Taryn
        {
            Debug.Log("colidiu");
            anim.SetBool("atack", true);
        }
    }
}
