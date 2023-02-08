using UnityEngine;

[RequireComponent(typeof(PlayerSettings))]
public class PlayerMovement : MonoBehaviour
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
        var inputMove = input * Time.deltaTime * playerSettings.speed;
        playerSettings.characterController.Move( new Vector3(inputMove.x, 0, inputMove.y) );
    }


}
