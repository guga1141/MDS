using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlEmotions : MonoBehaviour
{
    public Animator anim;

    [Header(" Ela esta sorrindo?")]
    public bool sorrindo;
    [Header("Ela esta feliz?")]
    public bool feliz;
    [Header("Ela esta com raiva?")]
    public bool com_raiva;
    [Header("Ela esta triste?")]
    public bool triste;
    [Header("Ela esta surpresa?")]
    public bool surpresa;

    void Start()
    {
        anim.SetBool("sorria", false);
        anim.SetBool("feliz", false);
        anim.SetBool("raiva", false);
        anim.SetBool("triste", false);
        anim.SetBool("surpresa", false);
        anim.SetBool("neutral", true);
    }

    void Update()
    {
        //Sorrir   
        if (Input.GetKeyDown("c"))
        {
            anim.SetBool("sorria", true);
            Debug.Log("Akane está sorrindo");
            sorrindo = true;
        }
        else
        {
            anim.SetBool("neutral", true);
        }

        //Feliz
        if (Input.GetKeyDown("v"))
        {
            anim.SetBool("feliz", true);
            Debug.Log("Akane está feliz");
            feliz = true;
        }
        else
        {
            anim.SetBool("neutral", true);
        }


        //Raiva
        if (Input.GetKeyDown("b"))
        {
            anim.SetBool("raiva", true);
            Debug.Log("Akane está com raiva");
            com_raiva = true;
        }
        else
        {
            anim.SetBool("neutral", true);
        }


        //Triste
        if (Input.GetKeyDown("n"))
        {
            anim.SetBool("triste", true);
            Debug.Log("Akane está triste");
            triste = true;
        }
        else
        {
            anim.SetBool("neutral", true);
        }


        //Supresa
        if (Input.GetKeyDown("m"))
        {
            anim.SetBool("surpresa", true);
            Debug.Log("Akane está surpresa");
            surpresa = true;
        }
        else
        {
            anim.SetBool("neutral", true);
        }

    }
}
