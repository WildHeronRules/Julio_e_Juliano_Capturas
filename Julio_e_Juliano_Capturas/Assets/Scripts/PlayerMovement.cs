
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    
    private PlayerInputs m_input;
    private Rigidbody2D rb;
    [SerializeField]
    private float playerSpeed = 5.0f, runningSpeed = 10f;
    private Vector2 moveInput = Vector2.zero;



    private float timer = 0f, stc = 1;
    public float sps;
    [SerializeField]
    private bool isRunning;

    [SerializeField]
    private bool isStopped;
   
   
    private PlayerCentral pCentral;

    private void Awake(){

        m_input = new PlayerInputs();

        m_input.Player.Run.performed += ctx => RunDone();
        m_input.Player.Run.canceled += ctx => RunFinish();
    }

    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        pCentral = this.gameObject.GetComponent<PlayerCentral>();
    }

    public void Move(InputAction.CallbackContext context){

        moveInput = context.ReadValue<Vector2>();

    }



    private void RunDone(){
        
        
        if(pCentral.Stamina > 0){
            isRunning = true;
            playerSpeed = runningSpeed;
        }

    }

    private void RunFinish(){
        playerSpeed = 5.0f;
        isRunning = false;
    }


    private void OnEnable(){

        m_input.Enable();

    }

    private void OnDisable(){
       
        m_input.Disable();

    }
    

    void Update(){
        timer += Time.deltaTime;
    }

    void FixedUpdate()
    {

        Vector2 move = new Vector2(moveInput.x, moveInput.y);

        if(move.x == 0 && move.y == 0){
            isStopped = true;
        }
        else{
            isStopped = false;
        }


        if(timer > stc && isRunning && isStopped == false){
            stc = timer + sps;
            pCentral.Stamina -= 0.5f;
                if(pCentral.Stamina <= 0){
                    RunFinish();
                }
        }


        rb.MovePosition(rb.position + move * playerSpeed * Time.deltaTime);

        
    }
}