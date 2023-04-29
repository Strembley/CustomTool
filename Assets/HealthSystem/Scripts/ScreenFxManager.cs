using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ScreenFxManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;

    [SerializeField] private CameraShake _cameraShake;


    [SerializeField] private NoiseSettings _flinch;
    [SerializeField] private NoiseSettings _heal;
    [SerializeField] private NoiseSettings _wince;
    [SerializeField] private NoiseSettings _concussion;

    private SfxManager _sfxManager;

    void Start()
    {
        //ConcussionStart();
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

            //_cameraShake.StartShakeAndBlur();


        }
    }

    public void WinceStart()
    {
        if (_healthData.WinceEffect)
        {

            //_cameraShake.StartShakeAndBlur();

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
