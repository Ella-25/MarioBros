using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    [SerializeField] float speed = 5f;

    private void Awake() //método chamado antes do start
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float xMove = Input.GetAxis("Horizontal"); //ao pressionar seta direita (right) ou D, xMove recebe 1, se esquerda e A recebe -1.
                                                   //Se não pressionar nada recebe 0
        rbPlayer.velocity = new Vector2(xMove * speed, rbPlayer.velocity.y);

        if (xMove > 0) //se estiver movimentando p/ direita
        {
            transform.eulerAngles = new Vector2(0,0); //para não rotacionar
        }
        else if (xMove < 0) //se estiver movimentando p/ esquerda, rotaciona o personagem 180y para a esquerda
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}
