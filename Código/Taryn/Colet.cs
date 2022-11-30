using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) // manipulação do componente colisor da Unity
    {
        if(collider.gameObject.layer == 7) //confere se a Taryn colidiu com os objetos
        {
            Destroy(gameObject); // coleta o objeto
        }
    }
}
