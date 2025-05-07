using UnityEngine;
using UnityEngine.Animations;

public class MoveCharacter : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] private float MoveSpeed;
    private Vector3 Velocity;
    private float Gravity = -9.8f;
    private bool IsGround;

    private void Start()
    {
        
        controller = GetComponent<CharacterController>();
        
    }
    void Update()
    {
        IsGround = controller.isGrounded;
        if (IsGround && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }
        if (Input.GetKey(KeyCode.Space) && IsGround)
        {
            Velocity.y = +12f;
        }
        float MoveX = Input.GetAxis("Vertical");
        float MoveZ = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * MoveX - transform.forward * MoveZ;
        controller.Move(move * MoveSpeed * Time.deltaTime);

        Velocity.y += Gravity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
    }
}
