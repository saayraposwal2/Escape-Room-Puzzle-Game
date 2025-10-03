using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;


public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float movespeed = 1f;
    private PlayerController playerController;
    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
        playerController = new PlayerController();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerController.Enable();
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void PlayerInput()
    {
        movement = playerController.movement.Move.ReadValue<Vector2>();
    }

    private void Move()
    {
        PlayerInput();
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
