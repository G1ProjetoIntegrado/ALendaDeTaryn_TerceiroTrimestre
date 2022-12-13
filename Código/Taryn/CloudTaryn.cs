using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTaryn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) //Ativa o collision quando o personagem estiver na tag platform
    {
        if(other.transform.tag == "Platform")
        {
            transform.parent = other.transform; //Personagem vira parente do objeto que esta se movendo
        }
    }

    private void OnCollisionExit2D(Collision2D other) //Desativa o parente
    {
        if(other.transform.tag == "Platform")
        {
            transform.parent = null;
        }
    }
}
