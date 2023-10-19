using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOfPlayer : MonoBehaviour
{
    public GameObject Fake_Player;
    public GameObject Real_Player;
    public GameObject Fake_Cam;
    public GameObject Real_Cam;
    public GameObject Mini_Map;
    void Start()
    {
        Fake_Cam.SetActive(true);
        Real_Cam.SetActive(false);
        Fake_Player.SetActive(true);
        Real_Player.SetActive(false);
        Mini_Map.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Fake_Cam.SetActive(false);
            Real_Cam.SetActive(true);
            Fake_Player.SetActive(false);
            Real_Player.SetActive(true);
            Mini_Map.SetActive(true);
        }
    }
}
