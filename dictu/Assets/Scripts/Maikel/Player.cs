using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    int moveSpeed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(horizontalMove, verticalMove).normalized * moveSpeed;
    }
}
