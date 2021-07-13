using UnityEngine;

namespace Minecraft
{
    public class PlayerGroundCheck : MonoBehaviour
    {
        public PlayerMovement playerMovement;
        private void OnTriggerEnter(Collider _)
         => playerMovement.grounded = true;
        private void OnTriggerExit(Collider _)
         => playerMovement.grounded = false;
    }
}