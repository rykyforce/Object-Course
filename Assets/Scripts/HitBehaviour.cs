using System;
using Unity.VisualScripting;
using UnityEngine;

public class HitBehaviour : MonoBehaviour
{
    [SerializeField] float constantDamage = 0.01f;
    [SerializeField] float hitDamage = 4f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Health health))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            health.TakeDamage(hitDamage);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Health health))
        {
            health.TakeDamage(constantDamage);
        }
    }
}
