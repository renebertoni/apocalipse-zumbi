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
        PlayerInputs.OnRotate += DoRotate;
    }

    void OnDisable() {
        PlayerInputs.OnMove -= DoMove;
        PlayerInputs.OnRotate -= DoRotate;
    }

    void DoMove(Vector2 input){
        var inputMove = input * Time.deltaTime * playerSettings.speed;
        playerSettings.characterController.Move( new Vector3(inputMove.x, 0, inputMove.y) );
    }

    void DoRotate(Vector2 mousePosition){
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red, 1000);
            Debug.Log(hit.collider.name);
            Vector3 lookPosition = hit.point;
            lookPosition.y = transform.position.y;
            transform.LookAt(lookPosition);
        }
    }
}
