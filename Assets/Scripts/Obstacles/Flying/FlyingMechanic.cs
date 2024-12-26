using System;
using Helpers;
using UnityEngine;

namespace Obstacles.Flying
{
    public class FlyingMechanic : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float moveSpeed;
        [SerializeField] private float minimumDistanceToActivate;
        public bool triggered = false;
        [SerializeField] private Vector3 lastKnownPosition;
        private void Start()
        {
            target = SingletonManager.Instance.player.transform;
            moveSpeed = 10.0f;
            minimumDistanceToActivate = 10f;
            triggered = false;
        }
        
        private void Update()
        {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance < minimumDistanceToActivate)
            {
                GetPlayerLastKnownPosition();
                MovePlayer(lastKnownPosition);     
                triggered = true;
            }
            else
            {
                if (triggered == false)
                {
                    MovePlayer(target.position);   
                }
            }
        }

        void MovePlayer(Vector3 position)
        {
            transform.position = Vector3.MoveTowards(transform.position, position, moveSpeed * Time.deltaTime);
        }

        void GetPlayerLastKnownPosition()
        {
            if (triggered == false)
            {
                lastKnownPosition = SingletonManager.Instance.player.transform.position;
            }
        }

    }
}
