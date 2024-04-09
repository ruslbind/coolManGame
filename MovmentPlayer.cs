using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{

    public float moveSpeed = 5f; // �������� ������������
    public float jumpForce = 8f; // ���� ������
    private bool isGrounded = false; // ���� ��� ��������, ��������� �� �������� �� �����
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        // ��������, ��������� �� �������� �� ����� (������������� � �����)
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.8f);

        // ���������� ��������� ����� � ������
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // ������
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    
}
