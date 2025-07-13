using UnityEngine;
using UnityEngine.InputSystem; // Bu kütüphaneyi eklemeyi unutmayın!

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Karakterin hareket hızı
    private Vector3 currentMovementInput; // Anlık hareket girişi

    // PlayerInput bileşeni tarafından çağrılacak metod
    // "PlayerInputActions" dosyanızdaki "Player" Action Map'inin içindeki "Move" Action'ının adı olmalı
    // .
    void Start()
    {
          
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        // Hareket verisi okuma. ReadValue<Vector2>() bize (x, y) koordinatları verir.
        currentMovementInput = context.ReadValue<Vector3>();
        
    }

    void Update()
    {
        // Her karede karakteri hareket ettir
        // transform.Translate(x hareketi, y hareketi, z hareketi)
        // currentMovementInput.x * moveSpeed * Time.deltaTime ile x ekseninde hareket,
        // currentMovementInput.y * moveSpeed * Time.deltaTime ile y ekseninde hareket sağlanır.
        // Z ekseninde hareket etmediğimiz için 0f.
        transform.Translate(currentMovementInput.x * moveSpeed * Time.deltaTime,0f
                            ,currentMovementInput.z * moveSpeed * Time.deltaTime
                            );
        
    }
}