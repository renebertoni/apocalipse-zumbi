using UnityEngine;
using System;

[RequireComponent(typeof(PlayerSettings))]
public class PlayerInputs : MonoBehaviour
{
    public static Action<Vector2> OnMove;
    public static Action<Vector2> OnRotate;

    PlayerSettings playerSettings;

    private void Awake() {
        playerSettings = GetComponent<PlayerSettings>();
    }

    void FixedUpdate()
    {
        ReadInputs();
    }

    void ReadInputs(){
        var inputDirection = playerSettings.movement.action.ReadValue<Vector2>();
        var inputRotation = playerSettings.pointerPosition.action.ReadValue<Vector2>();

        OnMove?.Invoke(inputDirection.normalized);
        OnRotate?.Invoke(inputRotation);
    }
}
