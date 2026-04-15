using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerInput playerInput;
    private InputAction moveAction;

    [SerializeField]
    float speed = 5f;

    [SerializeField]
    float rotateSpeed = 5f;

    private Vector3 currentDirection = Vector3.zero;
    private Vector3 directionVelocity = Vector3.zero;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
       
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        Vector3 targetDirection = new Vector3(input.x, 0, input.y);
        targetDirection = Vector3.ClampMagnitude(targetDirection, 1f);

        currentDirection = Vector3.SmoothDamp(currentDirection, targetDirection, ref directionVelocity, 0.1f);
        transform.position += currentDirection * speed * Time.deltaTime;

        //Player rotation
        if (currentDirection.magnitude > 0.01f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(currentDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        }
    }

}
