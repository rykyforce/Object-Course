using Player;
using UnityEngine;

namespace Obstacles
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] float enterDamage = 4f;
        [SerializeField] float stayDamage = 5f;
        [SerializeField] float speedDebuff = 8f;
        
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Health health))
            {
                health.TakeDamage(enterDamage);
            }
            if (other.TryGetComponent(out PlayerMovement playerMovement))
            {
                playerMovement.DecreaseSpeed(speedDebuff);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out Health health))
            {
                health.TakeDamage(stayDamage * Time.deltaTime);
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out PlayerMovement playerMovement))
            {
                playerMovement.StabilizeSpeed();
            }
        }
    }
}
