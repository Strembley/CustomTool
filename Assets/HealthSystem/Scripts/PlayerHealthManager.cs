using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;
    private SfxManager _sfxManager;
    private StatusManager _statusManager;
    private ScreenFxManager _screenFxManager;
    private ScreenFlasher _screenFlasher;


    [SerializeField] public bool _bleeding;

    private float lastDamageTime;


    private float _currentHealth;
    [SerializeField] private GameObject _deathScreen;
    [SerializeField] private GameObject _hpBar;

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public UnityEvent OnDamageTaken;




    private void Awake()
    {
        _sfxManager = GetComponent<SfxManager>();
        _statusManager = GetComponent<StatusManager>();
        _screenFxManager = GetComponent<ScreenFxManager>();
        _screenFlasher = GetComponent<ScreenFlasher>();
    }


    private void Start()
    {
        SetMaxHealth(_healthData.MaxHealth);
        
    }

    private void Update()
    {
        //Debug.Log(_currentHealth);
        if (_healthData.BleedOut)
        {
            if (_bleeding)
            {
                if (Time.time > lastDamageTime + _healthData.BleedDelay)
                {
                    // Damage the player
                    TakeDamage(_healthData.BleedDamage);
                    // Update the last damage time
                    lastDamageTime = Time.time;

                }
            }
            else
            {
                if (_screenFxManager._painPanel.activeSelf)
                {
                    _screenFxManager._painPanel.SetActive(false);
                }
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Projectile"))
        {
            Debug.Log("Projectile");
            OnDamageTaken.Invoke();
        }
    }

    
    private void Die()
    {
        _sfxManager.DeathSfxStart();
        _deathScreen.SetActive(true);
        _hpBar.SetActive(false);
    }

    public void TakeDamage(float damage) 
    {
        _currentHealth -= damage;
        _screenFlasher.StartFlashing(_screenFxManager._painPanel, .2f, 2);
        SetHealth(_currentHealth);
        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    public void HealHealth(float heal) 
    {
        _currentHealth += heal;
        _statusManager.QueueMessage("+" + heal + " Health", Color.green);
        SetHealth(_currentHealth);
    }

    public void SetMaxHealth(float maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        fill.color = gradient.Evaluate(1f);
        _currentHealth = maxHealth;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void StartBleed()
    {
        if (_bleeding == false) 
        { 
        Debug.Log("Bleeding Started");
        _statusManager.QueueMessage("You are now bleeding", Color.red);
        _bleeding = true;
        }
    }

    public void StopBleed() 
    {
        if (_bleeding == true)
        {
            Debug.Log("Bleeding Stopped");
            _statusManager.QueueMessage("You are no longer bleeding", Color.green);
            _bleeding = false;
        }
        
        
    }
}


