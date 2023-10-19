using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Events;

public class SanityManager : MonoBehaviour
{
    public Slider sanitySlider;
    public PostProcessProfile Profi;
    Vignette vig;
    public Animator anime;
    public int fullSanity;
    public int difficulty;
    float percent;

    public UnityEvent onInsane;

    void Start()
    {
        anime.SetBool("sorria", false);
        anime.SetBool("feliz", false);
        anime.SetBool("raiva", false);
        anime.SetBool("triste", false);
        anime.SetBool("surpresa", false);
        anime.SetBool("neutral", false);
        Profi.TryGetSettings(out vig);
        sanitySlider = GetComponent<Slider>();
        sanitySlider.maxValue = fullSanity;
        sanitySlider.value = fullSanity;
        vig.intensity.value = 0;
        StartCoroutine(LoseSanity());
    }

    IEnumerator LoseSanity()
    {

        while (sanitySlider.value > 0)
        {
            sanitySlider.value -= 2f * difficulty;
            float newValue = (sanitySlider.value - sanitySlider.maxValue) * -1;
            percent = newValue / sanitySlider.maxValue;
            vig.intensity.value = percent;

            yield return null;
        }
        onInsane.Invoke();
    }

    public void AffectSanity(float value)
    {
        sanitySlider.value += value;
    }
    public void CheckSanity()
    {
        if (percent == 0.80f)
        {
            Sanity20();
        }
        else if (percent == 0.60f)
        {
            Sanity40();
        }
        else if (percent == 0.40f)
        {
            Sanity60();
        }
        else if (percent == 0.20f)
        {
            Sanity80();
        }
        else if (percent == 0f)
        {
            Sanity100();
        }

        else
        {
            // Executar a��o quando a sa�de mental estiver acima de 75%
             Debug.Log("Sa�de mental acima de 75%");
        }
    }

    void Sanity100()
    {
        anime.SetBool("feliz", true);
        // Executar a��o quando a sa�de mental estiver abaixo ou igual a 25%
        Debug.Log("Sa�de mental abaixo ou igual a 100%");
    }
    void Sanity80()
    {
        anime.SetBool("feliz", false);
        anime.SetBool("sorria", true);
        // Executar a��o quando a sa�de mental estiver abaixo ou igual a 25%
        Debug.Log("Sa�de mental abaixo ou igual a 80%");
    }
    void Sanity60()
    {
        anime.SetBool("sorria", false);
        anime.SetBool("neutral", true);
        // Executar a��o quando a sa�de mental estiver abaixo ou igual a 50%
        Debug.Log("Sa�de mental abaixo ou igual a 60%");
    }
    void Sanity40()
    {
        anime.SetBool("neutral", false);
        anime.SetBool("triste", true);
        // Executar a��o quando a sa�de mental estiver abaixo ou igual a 75%
        Debug.Log("Sa�de mental abaixo ou igual a 40%");
    }
    void Sanity20()
    {
        anime.SetBool("triste", false);
        anime.SetBool("raiva", true);
        // Executar a��o quando a sa�de mental estiver abaixo ou igual a 75%
        Debug.Log("Sa�de mental abaixo ou igual a 20%");
    }
   
}