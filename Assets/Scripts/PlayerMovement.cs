using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float moveSpeed;

    Vector2 movement;
    Animator animator;
    public int rockplanks = 0;
    public Text rockplankUI;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Board"))
        {
            rockplanks++;
        }
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -30f, 30f), Mathf.Clamp(transform.position.y, -30f, 30f));

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        rockplankUI.text = rockplanks.ToString();
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + movement * moveSpeed *Time.fixedDeltaTime);
    }
}