using UnityEngine;

namespace Minecraft
{
    public class PlayerGroundCheck : MonoBehaviour
    {
        public RigidbodyMovement rbMovement;
        private void OnTriggerEnter(Collider _)
         => rbMovement.grounded = true;
        private void OnTriggerExit(Collider _)
         => rbMovement.grounded = false;
    }
}