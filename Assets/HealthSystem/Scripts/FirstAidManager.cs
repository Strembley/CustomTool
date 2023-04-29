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

    private int _bandagesUsed;
    private int _splintsUsed;

    public UnityEvent OnMedkitUse;
    public UnityEvent OnBandageUse;
    public UnityEvent OnSplintUse;

    public void UseMedkit() 
    {
        if (_healthData.FirstAid)
        {
            OnMedkitUse.Invoke();
            if (_healthData.StopBleeding)
            {
                _playerHealthManager.StopBleed();
                _playerHealthManager.HealHealth(_healthData.MedkitHealAmount);
                if (_healthData.MedkitSfx)
                {
                    _sfxManager.MedkitSfxStart();
                }
            }
            else
            {
                _playerHealthManager.HealHealth(_healthData.MedkitHealAmount);
            }
        }
        
    }

    public void UseBandage()
    {
        if (_healthData.FirstAid)
        {
            _bandagesUsed++;
            OnBandageUse.Invoke();
            _playerHealthManager.HealHealth(_healthData.BandageHealAmount);
            if (_healthData.BandageSfx)
            {
                _sfxManager.BandageSfxStart();
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
            _splintsUsed++;
            OnSplintUse.Invoke();
            _playerHealthManager.HealHealth(_healthData.SplintHealAmount);
            if (_healthData.SplintSfx)
            {
                _sfxManager.SplintSfxStart();
            }
            if (_splintsUsed > _healthData.FixLimbCount)
            {
                _limbManager.FixLeg();
                _splintsUsed = 0;
            }
        }
    }
}
