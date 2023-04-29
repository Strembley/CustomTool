using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ScreenFxManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;

    [SerializeField] private CameraShake _cameraShake;


    [SerializeField] private  NoiseSettings _flinch;

    private SfxManager _sfxManager;

    void Start()
    {
        ConcussionStart();
        FlinchStart();
    }

    public void FlinchStart() 
    {
        if (_healthData.FlinchEffect)
        {
            _cameraShake.StartShakeAndBlur(_flinch);

            if (_healthData.FlinchSfx)
            {
                _sfxManager.FlinchSfxStart();
            }
        }
    }

    public void HealStart() 
    {
        if (_healthData.HealEffect)
        {



            
        }
    }

    public void WinceStart()
    {
        if (_healthData.WinceEffect)
        {
            


        }
    }

    public void ConcussionStart()
    {
        if (_healthData.ConcussionEffect)
        {
            //_cameraShake.StartShakeAndBlur();
            if (_healthData.ConcussionEffect)
            {
                _sfxManager.ConcussionSfxStart();
            }
        }
    }
}
