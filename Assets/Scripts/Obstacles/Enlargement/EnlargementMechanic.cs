using UnityEngine;

namespace Obstacles.Enlargement
{
    public class EnlargementMechanic : MonoBehaviour
    {
        [Range(0f, 1f)] public float lerpTime;
        private Vector3 _defaultSize;
        private bool _canEnlarge = false;

        private void Start()
        {
            _defaultSize = transform.localScale;
            transform.localScale = Vector3.zero;
        }

        private void Update()
        {
            if (_canEnlarge)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, _defaultSize, Time.deltaTime * lerpTime);
                if (transform.localScale.x >= (_defaultSize.x - 0.1f))
                {
                   GetComponent<EnlargementMechanic>().enabled = false; 
                }
            }

        }

        public void Enlarge()
        {
            _canEnlarge = true;
        }

    }
}
