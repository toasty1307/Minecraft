using Minecraft.InputActions;
using UnityEngine;

namespace Minecraft
{
    [RequireComponent(typeof(RigidbodyMovement))]
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerInput playerInput;
        private RigidbodyMovement rbMovement;
        
        [Header("Camera Stuff")]
        [SerializeField] [Range(0f, 179f)] 
        private float FOV;
        [SerializeField] 
        private Utils.FloatRange lookRange;
        [SerializeField]
        private float mouseSensitivityX;
        [SerializeField]
        private float mouseSensitivityY;
        [SerializeField]
        private bool invertY;
        [SerializeField] 
        private Camera playerCamera;

        private float rotationX;
        
        private void Awake()
        {
            playerInput = new PlayerInput();
            rbMovement = GetComponent<RigidbodyMovement>();
            playerInput.Movement.Jump.performed += _ => rbMovement.Jump();
        }

        private void FixedUpdate()
        {
            var input = (Vector3)playerInput.Movement.Movement.ReadValue<Vector2>(); input.z = input.y; input.y = 0f;
            rbMovement.MoveTo(transform.position + (transform.forward * input.z + transform.right * input.x));
            
            // camera look stuff
            var mouseInput = playerInput.Look.Look.ReadValue<Vector2>().normalized * Time.fixedDeltaTime;
            var (xDelta, yDelta) = (mouseInput.x * mouseSensitivityX, mouseInput.y * mouseSensitivityY * (invertY ? -1f : 1f));
            rotationX -= yDelta;
            rotationX = Mathf.Clamp(rotationX, lookRange.Min, lookRange.Max);
            transform.Rotate(Vector3.up * xDelta);
            playerCamera.transform.rotation = Quaternion.Euler(rotationX, transform.rotation.eulerAngles.y, 0f);
        }

        private void OnEnable()
        {
            playerInput.Enable();
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }

        private void OnValidate()
        {
            playerCamera.fieldOfView = FOV;
        }
    }
}