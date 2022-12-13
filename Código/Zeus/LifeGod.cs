using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeGod : MonoBehaviour
{
    // public Slider barLife;
    public Slider barLife;
    public int MaxLife;
    public int AtualLife;

    void Start()
    {
        AtualLife = MaxLife;
        barLife.maxValue = MaxLife;
        barLife.value = AtualLife;
    }

    public void Dano(int damage)
    {
        AtualLife -= damage;
        barLife.value = AtualLife;
        if(AtualLife<= 0)
        {
            Debug.Log("Game Over");
        }
    }
}