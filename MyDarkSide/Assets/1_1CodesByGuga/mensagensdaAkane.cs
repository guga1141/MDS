using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensagensdaAkane : MonoBehaviour
{
    public Text[] textos;
    public KeyCode[] teclas;
    public float tempoDesaparecimento = 1.5f; // Tempo em segundos
    private int indiceTextoAtual = 0;
    private bool textoAtivo = false;

    void Start()
    {   // Desativar todos os textos
        for (int i = 0; i < textos.Length; i++)
        {
            textos[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        for (int i = 0; i < teclas.Length; i++)
        {
            if (Input.GetKeyDown(teclas[i]))
            {  // Ativar o texto correspondente
                AtivarTexto(i);
            }
        }

        if (textoAtivo)
        {   // Contar o tempo decorrido
            tempoDesaparecimento -= Time.deltaTime;

            if (tempoDesaparecimento <= 0f)
            {  // Desativar o texto após o tempo de desaparecimento
                DesativarTexto();
            }
        }
    }

    private void AtivarTexto(int indice)
    {   // Desativar o texto atual
        DesativarTexto();

        // Ativar o novo texto
        textos[indice].gameObject.SetActive(true);
        indiceTextoAtual = indice;
        textoAtivo = true;

        // Reiniciar o temporizador
        tempoDesaparecimento = 1.5f; // Valor personalizado ou variável
    }

    private void DesativarTexto()
    {  // Desativar o texto atual
        textos[indiceTextoAtual].gameObject.SetActive(false);
        textoAtivo = false;
    }
}
