using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed; //variável de velocidade
    bool left = true; //variável que declara a direção (ele vai começar sempre para esquerda)
    bool right = false; //variável que declara a direção

    // Update is called once per frame
    void Update()
    {
       if (right == true) // confere se ele está na direção correta 
       {
        transform.position = transform.position + (Vector3.right * speed * Time.deltaTime); //movimentação ultilizando o vetor
            if(transform.position.x >= 3) // confere se ele chegou no ponto máximo do cenário
            {
                right = false; //declara que ele chegou no ponto máximo 
                left = true; //muda a direção para direita
            }
       }

       if(left == true) // confere se ele está na direção correta 
       {
            transform.position = transform.position + (Vector3.left * speed * Time.deltaTime); //movimentação ultilizando o vetor
            if(transform.position.x <= -5) //declara que ele chegou no ponto minimo
            {
                    left = false; //muda a direção para esquerda
                    right = true; //declara que ele chegou no ponto máximo
            }
       }
       
    }

  
    
}
