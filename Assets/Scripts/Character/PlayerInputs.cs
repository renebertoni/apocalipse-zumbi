using UnityEngine;
using System;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerSettings))]
public class PlayerInputs : MonoBehaviour
{
    public static Action OnShoot;
    public static Action<Vector2> OnMove;
    public static Action<Vector2> OnRotate;

    PlayerSettings playerSettings;

    private void Awake() {
        playerSettings = GetComponent<PlayerSettings>();
    }

    private void OnEnable() {
        playerSettings.shoot.action.performed += Shoot;
    }
    private void OnDisable() {
        playerSettings.shoot.action.performed -= Shoot;
    }

    void FixedUpdate()
    {
        ReadInputs();
    }

    void ReadInputs(){
        var inputDirection = playerSettings.movement.action.ReadValue<Vector2>();
        var inputRotation = playerSettings.pointerPosition.action.ReadValue<Vector2>();
        
        OnRotate?.Invoke(inputRotation);
        OnMove?.Invoke(inputDirection.normalized);
    }

    void Shoot(InputAction.CallbackContext obj){
        OnShoot?.Invoke();
    }
}
