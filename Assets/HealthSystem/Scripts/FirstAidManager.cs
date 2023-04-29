using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FirstAidManager : MonoBehaviour
{

    [SerializeField] private HealthData _healthData;

    private PlayerHealthManager _playerHealthManager;
    private LimbManager _limbManager;
    private SfxManager _sfxManager;
    private ScreenFxManager _screenFxManager;

    private int _bandagesUsed;
    private int _splintsUsed;

    public UnityEvent OnMedkitUse;
    public UnityEvent OnBandageUse;
    public UnityEvent OnSplintUse;

    public void UseMedkit() 
    {
        if (_healthData.FirstAid)
        {
            Debug.Log("Medkit Used");
            _playerHealthManager.HealHealth(_healthData.MedkitHealAmount);
            OnMedkitUse.Invoke();
            //Check What Order To Play Effects
            if (_healthData.MedkitSfx && !_healthData.HealEffect)
            {
                _sfxManager.MedkitSfxStart();
            }
            else if (!_healthData.MedkitSfx && _healthData.HealEffect)
            {
                _screenFxManager.HealStart("Medkit");
            }
            else if (_healthData.MedkitSfx && _healthData.HealEffect)
            {
                _screenFxManager.HealStart("Medkit");
            }
            

            if (_healthData.StopBleeding)
            {
                _playerHealthManager.StopBleed();
            }

        }
        
    }

    public void UseBandage()
    {
        if (_healthData.FirstAid)
        {
            Debug.Log("Bandage Used");
            _bandagesUsed++;
            OnBandageUse.Invoke();
            _playerHealthManager.HealHealth(_healthData.BandageHealAmount);

            //Check What Order To Play Effects
            if (_healthData.BandageSfx && !_healthData.HealEffect)
            {
                _sfxManager.BandageSfxStart();
            }
            else if (!_healthData.BandageSfx && _healthData.HealEffect)
            {
                _screenFxManager.HealStart("Bandage");
            }
            else if (_healthData.BandageSfx && _healthData.HealEffect)
            {
                _screenFxManager.HealStart("Bandage");
            }


            if (_bandagesUsed > _healthData.StopBleedCount)
            {
                _playerHealthManager.StopBleed();
                _bandagesUsed = 0;
            }
        }
    }

    public void UseSplint()
    {
        if (_healthData.FirstAid)
        {
            Debug.Log("Splint Used");
            _splintsUsed++;
            OnSplintUse.Invoke();
            _playerHealthManager.HealHealth(_healthData.SplintHealAmount);

            //Check What Order To Play Effects
            if (_healthData.SplintSfx && !_healthData.HealEffect)
            {
                _sfxManager.SplintSfxStart();
            }
            else if (!_healthData.SplintSfx && _healthData.HealEffect)
            {
                _screenFxManager.HealStart("Splint");
            }
            else if (_healthData.SplintSfx && _healthData.HealEffect)
            {
                _screenFxManager.HealStart("Splint");
            }

            if (_splintsUsed > _healthData.FixLimbCount)
            {
                _limbManager.FixLeg();
                _limbManager.FixArm();
                _limbManager.FixHead();
                _splintsUsed = 0;
            }
        }
    }
}
