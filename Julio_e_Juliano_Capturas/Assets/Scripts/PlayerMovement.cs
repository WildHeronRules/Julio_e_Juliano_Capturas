
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float playerSpeed = 40.0f;
    private Vector2 moveInput = Vector2.zero;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Move(InputAction.CallbackContext context){

        moveInput = context.ReadValue<Vector2>();

    }

    void Update()
    {

        Vector2 move = new Vector2(moveInput.x, moveInput.y);
        rb.MovePosition(rb.position + move * playerSpeed * Time.deltaTime);

    }
}