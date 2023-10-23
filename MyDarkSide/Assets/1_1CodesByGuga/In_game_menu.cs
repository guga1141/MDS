using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_game_menu : MonoBehaviour
{
    public GameObject IGM;
        
    void Start()
    {
           IGM.SetActive(false);
    }

   
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            IGM.SetActive(true);
            Debug.Log("Esc apertado");
        }
        else if (Input.GetKeyDown("escape"))
        {
            IGM.SetActive(false);
            Debug.Log("Esc desapertado");
        }
        // if (Input.GetKeyUp("escape"))
        {
          //  IGM.SetActive(false);
         // Debug.Log("Esc desapertado");
        }
    }
}
