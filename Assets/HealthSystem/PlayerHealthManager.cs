using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;

    public UnityEvent OnDamageTaken;

    private float _currentHealth;
    //[SerializeField] private GameObject _deathScreen;
    //[SerializeField] private GameObject _hpBar;

    //public Slider slider;
    //public Gradient gradient;
    //public Image fill;

    private void Start()
    {
        SetMaxHealth(_healthData.MaxHealth);
    }

    private void Update()
    {
        Debug.Log(_currentHealth);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Projectile"))
        {
            Debug.Log("Projectile");
            OnDamageTaken.Invoke();
        }



        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //_deathScreen.SetActive(true);
        //_hpBar.SetActive(false);
    }

    public void SetMaxHealth(float maxHealth)
    {
        //slider.maxValue = maxHealth;
        //slider.value = maxHealth;
        //fill.color = gradient.Evaluate(1f);
        _currentHealth = maxHealth;
    }
    public void SetHealth(float health)
    {
        //slider.value = health;
        //fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
