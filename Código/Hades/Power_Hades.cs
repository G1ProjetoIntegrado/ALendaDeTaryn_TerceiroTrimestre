using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Hades : MonoBehaviour
{
    public int damageEnimes;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Life>().Dano(damageEnimes);
        }
    }
}
