using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public float forceMultiplier = 10f; // Швидкість руху
    public float maxVelocity = 10f;    // Максимальна швидкість
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

        // Управління клавіатурою
        float horizontal = Input.GetAxis("Horizontal"); // A/D, стрілки ліворуч/праворуч
        float vertical = Input.GetAxis("Vertical");     // W/S, стрілки вгору/вниз

        // Додаємо силу по осях із врахуванням напряму forwardTransform
        Vector3 forward = forwardTransform.forward * vertical;
        Vector3 right = forwardTransform.right * horizontal;

        force = (forward + right) * forceMultiplier;

        // Додаємо силу до Rigidbody
        ballRigidbody.AddForce(force);
    }

    private void LimitVelocity()
    {
        // Перевірка поточної швидкості
        if (ballRigidbody.velocity.magnitude <= maxVelocity) return;
        // Обмежуємо швидкість до maxVelocity
        ballRigidbody.velocity = ballRigidbody.velocity.normalized * maxVelocity;
    }
}