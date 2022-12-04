using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody2D rigid;
    private float speed = 3;
    private float h;
    private float v;
    private Animator anim;
    private SpriteRenderer render;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");



    }

    private void FixedUpdate()
    {
        anim.SetFloat("speed", Mathf.Abs(h));

        if (h < 0)
        {
            render.flipX = true;
        }
        else
        {
            render.flipX = false;
        }
        rigid.velocity = new Vector2(h * speed, rigid.velocity.y);



    }
}

