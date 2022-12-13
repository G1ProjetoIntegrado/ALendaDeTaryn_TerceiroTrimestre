using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    public float velocityThunder;
    public int damage;

    void OnTriggerEnter2D(Collider2D other) //Verifica se algo colidiu
    {
        if(other.gameObject.CompareTag("Player")) //Verefica se é o raio
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<Life>().Dano(damage);
            //Acessa o script de vida de jogador e da dano nele
        }
    }

}
