using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAnimation : MonoBehaviour
{
    public Animator Anime;

    [Header(" Ela esta andando para que lado?")]

    public bool FRENTE;
    public bool TRAS;
    public bool ESQUERDA;
    public bool DIREITA;

    void Start()
    {
        Anime.SetBool("isWalk", false);
    }

    
    void FixedUpdate()
    {     
               //FRENTE//
        if (Input.GetKeyDown("w"))
        {
          Anime.SetBool("isWalk", true);
          Debug.Log("Akane esta andando para FRENTE");
            FRENTE = true;
        }
        if (Input.GetKeyUp("w"))
        {
          Anime.SetBool("isWalk", false);
          Debug.Log("Akane nao esta mais andando para FRENTE");
            FRENTE = false;
        }
                //TRAS//
        if (Input.GetKeyDown("s"))
        {
          Anime.SetBool("isWalk", true);
          Debug.Log("Akane esta andando para TRAS");
            TRAS = true;
        }
        if (Input.GetKeyUp("s"))
        {
          Anime.SetBool("isWalk", false);
          Debug.Log("Akane nao esta mais andando para TRAS");
            TRAS = false;
        }
              //ESQUERDA//
        if (Input.GetKeyDown("a"))
        {
            Anime.SetBool("isWalk", true);
            Debug.Log("Akane esta andando para ESQUERDA");
            ESQUERDA = true;
        }
        if (Input.GetKeyUp("a"))
        {
            Anime.SetBool("isWalk", false);
            Debug.Log("Akane nao esta mais andando para ESQUERDA");
            ESQUERDA = false;
        }
               //DIREITA//
        if (Input.GetKeyDown("d"))
        {
            Anime.SetBool("isWalk", true);
            Debug.Log("Akane esta andando para DIREITA");
            DIREITA = true;
        }
        if (Input.GetKeyUp("d"))
        {
            Anime.SetBool("isWalk", false);
            Debug.Log("Akane nao esta mais andando para DIREITA");
            DIREITA = false;
        }

    }
}
