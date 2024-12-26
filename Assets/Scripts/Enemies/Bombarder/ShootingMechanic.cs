using System.Collections.Generic;
using UnityEngine;

namespace Enemies.Bombarder
{
    public class ShootingMechanic : MonoBehaviour
    {
        [SerializeField] Transform spawnPoint;
        [SerializeField] Transform bulletPrefab;

        [SerializeField] private List<Transform> liveBullets;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            liveBullets = new List<Transform>();
            SpawnBullet(bulletPrefab);
        }
        
        void SpawnBullet(Transform bullet)
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            liveBullets.Add(bullet);
        }
    }
}
