using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBegginingOfInsanity : MonoBehaviour
{
    public GameObject Slider;   
    public BoxCollider Backup;

    private void OnTriggerEnter(Collider other)
    {
        Slider.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Slider.SetActive(false);
    }
}
