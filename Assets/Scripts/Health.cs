using System;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100;
    [SerializeField] Slider healthSlider;

    private void Update()
    {
        healthSlider.value = health;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
