using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterHandler : MonoBehaviour
{
    // components
    [SerializeField]
    public InputActionReference movement, shoot, pointerPosition;
    private CharacterController characterController;
    private PlayerInput playerInput;
    private Animator animator;

    // attributes
    public float moveSpeed = 2;

    private void Awake() {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        ReadInputs();
    }

    void ReadInputs(){
        // movement input
        var inputDirection = movement.action.ReadValue<Vector2>();
        DoMove(inputDirection.normalized);
    }

    void DoMove(Vector2 input){
        MoveAnimation(input);
        var inputMove = input * Time.deltaTime * moveSpeed;
        characterController.Move( new Vector3(inputMove.x, 0, inputMove.y) );
    }

    void MoveAnimation(Vector2 input){
        var speed = Mathf.Abs(input.x) + Mathf.Abs(input.y);
        animator.SetFloat("moveSpeed", Mathf.Clamp(speed, 0, 1));
    }
}
