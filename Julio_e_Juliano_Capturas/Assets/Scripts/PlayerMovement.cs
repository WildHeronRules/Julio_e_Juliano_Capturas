
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    
    private PlayerInputs m_input;
    private Rigidbody2D rb;
    [SerializeField]
    private float playerSpeed = 5.0f;
    private Vector2 moveInput = Vector2.zero;


    private void Awake(){

        m_input = new PlayerInputs();

        m_input.Player.Run.performed += ctx => RunDone();
        m_input.Player.Run.canceled += ctx => RunFinish();
    }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Move(InputAction.CallbackContext context){

        moveInput = context.ReadValue<Vector2>();

    }

    private void RunDone(){
        playerSpeed *= 2;
    }

    private void RunFinish(){
        playerSpeed = 5.0f;
    }


    private void OnEnable(){

        m_input.Enable();

    }

    private void OnDisable(){
       
        m_input.Disable();

    }
    


    void FixedUpdate()
    {

        Vector2 move = new Vector2(moveInput.x, moveInput.y);
        rb.MovePosition(rb.position + move * playerSpeed * Time.deltaTime);

        
    }
}