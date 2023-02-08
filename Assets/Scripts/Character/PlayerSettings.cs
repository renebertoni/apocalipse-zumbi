using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSettings : MonoBehaviour
{
    // components
    [SerializeField]
    public InputActionReference movement, shoot, pointerPosition;
    [HideInInspector]
    public CharacterController characterController;
    [HideInInspector]
    public Animator animator;

    // attributes
    public static Vector3 position;
    public float speed = 2;

    private void Awake() {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        position = transform.position;
    }
}
