using System;
using Unity.VisualScripting;
using UnityEngine;

public class HitBehaviour : MonoBehaviour
{
    [SerializeField] float hitDamage = 4f;
    [SerializeField] bool hasInteracted = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (hasInteracted)
        {
            return;
        }
        if (other.TryGetComponent(out Health health))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            health.TakeDamage(hitDamage);
            hasInteracted = true;
        }
        if (other.TryGetComponent(out Scorer scorer))
        {
            scorer.UpdateTimesBumped();
        }
    }
}
