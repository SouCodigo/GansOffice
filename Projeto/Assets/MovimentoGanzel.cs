using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoGanzel : MonoBehaviour
{
    public float velocidade = 5f;  // Velocidade de movimento do Ganzel

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal"); // Movimento Horizontal (para os lados)
        float movimentoVertical = Input.GetAxis("Vertical"); // Movimento Vertical (para cima e para baixo)

        Vector2 direcao = new Vector2(movimentoHorizontal, movimentoVertical);

        if (direcao.magnitude > 1f)
        {
            direcao.Normalize();
        }

        rb2d.velocity = direcao * velocidade;
    }
}

