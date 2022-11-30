using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Slider Lifebar;
    public int MaxLife;
    public int AtualLife;
    Animator anim;


    void Start()
    {
        AtualLife = MaxLife;
        Lifebar.maxValue = MaxLife;
        Lifebar.value = AtualLife;
        anim = GetComponent<Animator>();
    }

    public void Dano(int damage)
    {
        AtualLife -= damage;
        
        Lifebar.value = AtualLife;
        if(AtualLife<= 0)
        {
           anim.SetBool("Damage",true);
        }
    }
}
