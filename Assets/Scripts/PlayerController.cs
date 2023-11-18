using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;

    void Start()
    {

    }

    void Update()
    {
        movimentPlayer();
    }

    public void movimentPlayer()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(movimentoHorizontal, movimentoVertical, 0);

        transform.position += direcao * velocidade * Time.deltaTime;
    }
}
