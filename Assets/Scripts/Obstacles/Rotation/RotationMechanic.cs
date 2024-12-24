using UnityEngine;

namespace Obstacles.Rotation
{
    public class RotationMechanic : MonoBehaviour
    {
    [SerializeField] Vector3 rotationAxis;
        private void Update()
        {
            transform.Rotate(rotationAxis);
        }
    }
}
