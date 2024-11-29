using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public float forceMultiplier = 10f; // �������� ����
    public float maxVelocity = 10f;    // ����������� ��������
    [SerializeField] private Rigidbody ballRigidbody;
    [SerializeField] private Transform forwardTransform;

    private void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        LimitVelocity();
    }

    private void HandleInput()
    {
        Vector3 force = Vector3.zero;

        // ��������� ����������
        float horizontal = Input.GetAxis("Horizontal"); // A/D, ������ ������/��������
        float vertical = Input.GetAxis("Vertical");     // W/S, ������ �����/����

        // ������ ���� �� ���� �� ����������� ������� forwardTransform
        Vector3 forward = forwardTransform.forward * vertical;
        Vector3 right = forwardTransform.right * horizontal;

        force = (forward + right) * forceMultiplier;

        // ������ ���� �� Rigidbody
        ballRigidbody.AddForce(force);
    }

    private void LimitVelocity()
    {
        // �������� ������� ��������
        if (ballRigidbody.velocity.magnitude <= maxVelocity) return;
        // �������� �������� �� maxVelocity
        ballRigidbody.velocity = ballRigidbody.velocity.normalized * maxVelocity;
    }
}