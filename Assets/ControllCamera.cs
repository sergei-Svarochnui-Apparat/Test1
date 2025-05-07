using UnityEngine;

public class ControllCamera : MonoBehaviour
{
    [SerializeField] private float MouseSensetive = 100f;
    [SerializeField] private float MinVerticalAngle = -80;
    [SerializeField] private float MaxVerticalAngle = 80f;
    public Transform PlayerBody;
    private float XRotation = 0f;
    private Quaternion initialLocalRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        initialLocalRotation = transform.localRotation;
    }
    private void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSensetive * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensetive * Time.deltaTime;
        XRotation -= MouseY;
        XRotation = Mathf.Clamp(XRotation, MinVerticalAngle, MaxVerticalAngle);

        transform.localRotation = initialLocalRotation * Quaternion.Euler(XRotation, 0, 0);

        PlayerBody.Rotate(Vector3.up * MouseX);
    }
}
