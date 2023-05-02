using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(ScreenFlasher))]
public class ScreenFxManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;

    [SerializeField] private CameraShake _cameraShake;

    private SfxManager _sfxManager;
    private ScreenFlasher _screenFlasher;

    [SerializeField] private NoiseSettings _flinchNoise;
    [SerializeField] private NoiseSettings _healNoise;
    [SerializeField] private NoiseSettings _concussionNoise;

    [SerializeField] public GameObject _damagePanel;
    [SerializeField] private GameObject _healPanel;
    [SerializeField] private GameObject _blindingPanel;


    private void Awake()
    {
        _sfxManager = GetComponent<SfxManager>();
        _screenFlasher = GetComponent<ScreenFlasher>();
    }
    void Start()
    {
        
    }

    public void FlinchStart() 
    {
        _screenFlasher.StartFlashing(_blindingPanel, .5f, 2);
        Debug.Log("Flinch ScreenEffect");
        if (_healthData.FlinchEffect)
        {
            _cameraShake.StartShakeAndBlur(_flinchNoise);

            if (_healthData.FlinchSfx)
            {
                _sfxManager.FlinchSfxStart();
            }
        }
    }

    public void HealStart(string healType) 
    {
        _screenFlasher.StartFlashing(_healPanel, .5f, 2);
        Debug.Log("Heal ScreenEffect");
        if (_healthData.HealEffect)
        {
            _cameraShake.StartShakeAndBlur(_healNoise);
            _screenFlasher.StartFlashing(_healPanel, .5f, 2);

            //Check Heal Type and Play Correct Sound
            if (healType == "Medkit")
            {
                if (_healthData.MedkitSfx)
                {
                    _sfxManager.MedkitSfxStart();
                }
            }
            else if (healType == "Bandage")
            {
                if (_healthData.BandageSfx)
                {
                    _sfxManager.BandageSfxStart();
                }
            }
            else if (healType == "Splint") 
            {
                if (_healthData.SplintSfx)
                {
                    _sfxManager.SplintSfxStart();
                }
            }
            
            


        }
    }

    public void ConcussionStart()
    {
        _screenFlasher.StartFlashing(_blindingPanel, 1f, 2);
        if (_healthData.ConcussionEffect)
        {
            Debug.Log("Concussion ScreenEffect");
            _cameraShake.StartShakeAndBlur(_concussionNoise);
            
            
            if (_healthData.ConcussionEffect)
            {
                _sfxManager.ConcussionSfxStart();
            }
        }
        
    }
}
