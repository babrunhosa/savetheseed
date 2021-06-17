using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzesSemaforo : MonoBehaviour
{
    public float tempoVermelho, tempoLaranja, tempoVerde, tempo_basevermelha, tempo_baselaranja, tempo_baseverde;
    public bool luzVermelha, luzLaranja, luzVerde;

    public GameObject cilindroVermelho, cilindroLaranja, cilindroVerde;
    
    // Start is called before the first frame update
    void Start()
    {
        tempoVermelho = tempo_basevermelha;
        tempoLaranja = tempo_baselaranja;
        tempoVerde = tempo_baseverde;
        luzVermelha = true;
        luzLaranja = false;
        luzVerde = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (luzVermelha == true)
        {
            tempoVermelho -= Time.deltaTime;
            cilindroVermelho.SetActive(true);
            cilindroLaranja.SetActive(false);
            cilindroVerde.SetActive(false);

            if (tempoVermelho <= 0)
            {
                luzVerde = true;
                luzVermelha = false;
            }
        }

        if (luzLaranja == true)
        {
            tempoLaranja -= Time.deltaTime;
            cilindroVermelho.SetActive(false);
            cilindroLaranja.SetActive(true);
            cilindroVerde.SetActive(false);

            if (tempoLaranja <= 0)
            {
                Start();
            }
        }

        if (luzVerde == true)
        {
            tempoVerde -= Time.deltaTime;
            cilindroVermelho.SetActive(false);
            cilindroLaranja.SetActive(false);
            cilindroVerde.SetActive(true);

            if (tempoVerde <= 0)
            {
                luzVerde = false;
                luzLaranja = true;
            }
        }
    }

}
