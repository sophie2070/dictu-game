using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    float inputMagnitude;
    [SerializeField]
    private float rotationSpeed;
    int moveSpeed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontalMove, verticalMove).normalized;
        inputMagnitude = Mathf.Clamp01(rb.velocity.magnitude);
        transform.Translate(rb.velocity * moveSpeed * inputMagnitude * Time.deltaTime, Space.World);

        if (rb.velocity != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, rb.velocity);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
