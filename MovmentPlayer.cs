using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{

    public float moveSpeed = 5f; // Скорость передвижения
    public float jumpForce = 8f; // Сила прыжка
    private bool isGrounded = false; // Флаг для проверки, находится ли персонаж на земле
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        // Проверка, находится ли персонаж на земле (прикосновение к земле)
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.8f);

        // Управление движением влево и вправо
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Прыжок
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    
}
