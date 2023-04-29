using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ScreenFxManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;

    [SerializeField] private CameraShake _cameraShake;

    private SfxManager _sfxManager;

    [SerializeField] private NoiseSettings _flinch;
    [SerializeField] private NoiseSettings _heal;
    [SerializeField] private NoiseSettings _wince;
    [SerializeField] private NoiseSettings _concussion;


    private void Awake()
    {
        _sfxManager = GetComponent<SfxManager>();
    }
    void Start()
    {
        //ConcussionStart();
        //FlinchStart();
    }

    public void FlinchStart() 
    {
        Debug.Log("Flinch ScreenEffect");
        if (_healthData.FlinchEffect)
        {
            _cameraShake.StartShakeAndBlur(_flinch);

            if (_healthData.FlinchSfx)
            {
                _sfxManager.FlinchSfxStart();
            }
        }
    }

    public void HealStart(string healType) 
    {
        Debug.Log("Heal ScreenEffect");
        if (_healthData.HealEffect)
        {
            //_cameraShake.StartShakeAndBlur(_heal);

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

    public void WinceStart()
    {
        if (_healthData.WinceEffect)
        {
            Debug.Log("Wince ScreenEffect");
            //_cameraShake.StartShakeAndBlur(_wince);

        }
    }

    public void ConcussionStart()
    {
        if (_healthData.ConcussionEffect)
        {
            Debug.Log("Concussion ScreenEffect");
            //_cameraShake.StartShakeAndBlur(concussion);
            if (_healthData.ConcussionEffect)
            {
                _sfxManager.ConcussionSfxStart();
            }
        }
    }
}
