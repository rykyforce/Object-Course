using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float movementSpeed = 10.0f;
        private float _storedSpeed;

        void Update()
        {
            InputToMovementTranslation();
        }

        void InputToMovementTranslation()
        {
            float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
            float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
            transform.Translate(new Vector3(xValue, 0 , zValue));
        }

        public void DecreaseSpeed(float amount)
        {
            _storedSpeed = movementSpeed;
            movementSpeed -= amount;
        }
        public void StabilizeSpeed()
        {
            movementSpeed = _storedSpeed;
        } 
    }
}
