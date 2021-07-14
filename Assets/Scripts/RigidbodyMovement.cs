using UnityEngine;

namespace Minecraft
{
    [RequireComponent(typeof(Rigidbody))]
    public class RigidbodyMovement : MonoBehaviour
    {
        private Rigidbody body;

        [Header("Movement")]
        [SerializeField] 
        private float accelerationAmount;
        [SerializeField]
        private float runMultiplier = 1.5f;
        [SerializeField] 
        private float jumpHeight;
        [SerializeField] [Range(0f, 1f)] 
        private float counterMovement;
        [HideInInspector]
        public bool grounded;
        [HideInInspector]
        public bool running;

        private Vector3 destination;
        public bool IsAtDestination => Mathf.Approximately(Vector3.Distance(transform.position, destination), 0f);

        private void Awake()
        {
            body = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        protected void FixedUpdate()
        {
            var counterMovementVec = body.velocity * counterMovement; counterMovementVec.y = 0;
            body.velocity -= counterMovementVec;
            if (IsAtDestination) return;

            var direction = destination - transform.position;
            var amountToMoveBy = direction * (accelerationAmount * (running ? runMultiplier : 1f)); amountToMoveBy.y = 0;
            body.velocity += amountToMoveBy;
        }

        public void MoveTo(Vector3 position) => destination = position;
        
        public void Jump()
        {
            body.velocity += Vector3.up * (grounded ? jumpHeight : 0f);
        }
    }
}