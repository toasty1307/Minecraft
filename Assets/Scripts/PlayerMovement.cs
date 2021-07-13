using Minecraft.InputActions;
using UnityEngine;

namespace Minecraft
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerInput playerInput;
        private Rigidbody body;

        [Header("Camera Stuff")]
        [SerializeField] [Range(0f, 179f)] 
        private float FOV;
        [SerializeField] [Range(-180f, 0f)] 
        private float lowerLookLimit;
        [SerializeField] [Range(0f, 180f)] 
        private float higherLookLimit;
        [SerializeField]
        private float mouseSensitivityX;
        [SerializeField]
        private float mouseSensitivityY;
        [SerializeField]
        private bool invertY;
        [SerializeField] 
        private Camera playerCamera;
        [Header("Movement")]
        [SerializeField] 
        private float accelerationAmount;
        [SerializeField] 
        private float jumpHeight;
        [SerializeField] [Range(0f, 1f)] 
        private float counterMovement;
        [HideInInspector]
        public bool grounded;

        private float rotationX;
        private float rotationY;

        private void Awake()
        {
            playerInput = new PlayerInput();
            body = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            playerInput.Enable();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }

        private void FixedUpdate()
        {
            // movement
            var input = (Vector3) playerInput.Movement.Movement.ReadValue<Vector2>() * (accelerationAmount * Time.fixedDeltaTime);
            input.z = input.y;
            input.y = grounded ? playerInput.Movement.Jump.ReadValue<float>() * jumpHeight : 0f;
            var counterMovementToApply = -body.velocity * counterMovement;
            counterMovementToApply.y = 0;
            body.velocity += input + counterMovementToApply;
            
            // camera
            var mouseInput = playerInput.Look.Look.ReadValue<Vector2>() * Time.fixedDeltaTime;
            mouseInput.x = Mathf.Clamp(mouseInput.x, -1f, 1f) * mouseSensitivityX;
            mouseInput.y = Mathf.Clamp(mouseInput.y, -1f, 1f) * mouseSensitivityY;
            
            transform.Rotate(Vector3.up * mouseInput.x);
            playerCamera.transform.Rotate(Vector3.right * mouseInput.y);
            playerCamera.transform.rotation = Quaternion.Euler(Mathf.Clamp(playerCamera.transform.eulerAngles.x, lowerLookLimit, higherLookLimit), playerCamera.transform.eulerAngles.z, playerCamera.transform.eulerAngles.z);
        }

        private void OnValidate()
        {
            playerCamera.fieldOfView = FOV;
        }
    }
}