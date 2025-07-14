using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public float moveSpeed = 5f;
    
    private Vector2 currentMovementInput;
    private Rigidbody playerRb;
    private InputMaster inputMaster;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravityScale;
    [SerializeField] private bool isOnGround = true;



    void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.freezeRotation = true;
        inputMaster = new InputMaster();
        Physics.gravity *= gravityScale;

    }

    public void OnMove(InputAction.CallbackContext context)
    {

        currentMovementInput = context.ReadValue<Vector2>();


    }

    void Update()
    {

        float moveX = currentMovementInput.x * moveSpeed * Time.deltaTime;
        float moveZ = currentMovementInput.y * moveSpeed * Time.deltaTime;

        transform.Translate(moveX, 0f, moveZ);

        gameManager.Anxiety();

    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }

}