using UnityEngine;

namespace Helpers
{
    public class SingletonManager : MonoBehaviour
    {
        public static SingletonManager Instance { get; private set; }

        public GameObject player;
    
        private void Awake()
        {
            if (Instance != null && Instance != this) 
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }
        }
    }
}
