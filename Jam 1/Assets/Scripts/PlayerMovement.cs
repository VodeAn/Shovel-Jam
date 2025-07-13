using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Vector2 currentMovementInput; 

   
    void Start()
    {
          
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        
        currentMovementInput = context.ReadValue<Vector2>();
        
    }

    void Update()
    {
        
        transform.Translate(currentMovementInput.x * moveSpeed * Time.deltaTime,0f
                            ,currentMovementInput.y * moveSpeed * Time.deltaTime
                            );
        
    }
}