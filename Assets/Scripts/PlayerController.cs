using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public Animator anim;

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

        anim.SetFloat("Horizontal", direcao.x);
        anim.SetFloat("Vertical", direcao.y);
        anim.SetFloat("Speed", direcao.magnitude);

        transform.position += direcao * velocidade * Time.deltaTime;
    }
}
