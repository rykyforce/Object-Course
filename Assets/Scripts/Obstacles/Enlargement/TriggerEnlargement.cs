using UnityEngine;

namespace Obstacles.Enlargement
{
    public class TriggerEnlargement : MonoBehaviour
    {
        [SerializeField] EnlargementMechanic enlargementMechanic;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                enlargementMechanic.Enlarge();
                Destroy(gameObject);
            }
        }

    }
}
