using UnityEngine;

[RequireComponent(typeof(PlayerSettings))]
public class PlayerAnimation : MonoBehaviour
{
    PlayerSettings playerSettings;

    void Awake(){
        playerSettings = GetComponent<PlayerSettings>();
    }

    void OnEnable() {
        PlayerInputs.OnMove += DoMove;
    }

    void OnDisable() {
        PlayerInputs.OnMove -= DoMove;
    }

    void DoMove(Vector2 input){
        var speed = Mathf.Abs(input.x) + Mathf.Abs(input.y);
        playerSettings.animator.SetFloat("moveSpeed", Mathf.Clamp(speed, 0, 1));
    }
}
