using UnityEngine;
using System;

[RequireComponent(typeof(PlayerSettings))]
public class PlayerInputs : MonoBehaviour
{
    public static Action<Vector2> OnMove;

    PlayerSettings playerSettings;

    private void Awake() {
        playerSettings = GetComponent<PlayerSettings>();
    }

    void FixedUpdate()
    {
        ReadInputs();
    }

    void ReadInputs(){
        // movement input
        var inputDirection = playerSettings.movement.action.ReadValue<Vector2>();
        OnMove?.Invoke(inputDirection.normalized);
    }
}
