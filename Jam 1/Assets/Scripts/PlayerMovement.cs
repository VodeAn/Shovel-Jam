using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private GameManager gameManager;
    public float moveSpeed = 5f;
    private float anxietyMeter = 0;
    private Vector2 currentMovementInput;
    private Rigidbody playerRb;


    void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.freezeRotation = true;
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

        gameManager.Anxiety(anxietyMeter);
        
                         


        
        
    }
}