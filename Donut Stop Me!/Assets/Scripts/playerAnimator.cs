using UnityEngine;
using UnityEngine.InputSystem;

public class playerAnimator : MonoBehaviour
{
    private Animator animator;
    private InputAction moveAction;
    private InputAction jumpAction;

    void Awake()
    {
        var playerInput = GetComponent<PlayerInput>();
        if (playerInput != null)
        {
            moveAction = playerInput.actions.FindAction("Move");
            moveAction.Enable();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        bool isRunning = moveAction.ReadValue<Vector2>().magnitude > 0.1f;

        if (animator != null)
        {
            animator.SetBool("isRunning", isRunning);
        }
    }
}
