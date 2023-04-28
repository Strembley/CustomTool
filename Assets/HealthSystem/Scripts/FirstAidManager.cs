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


    private int _bandagesUsed;
    private int _splintsUsed;

    public UnityEvent OnMedkitUse;
    public UnityEvent OnBandageUse;
    public UnityEvent OnSplintUse;

    public void UseMedkit() 
    {
        OnMedkitUse.Invoke();
        if (_healthData.StopBleeding)
        {
            _playerHealthManager.StopBleed();
            _playerHealthManager.HealHealth(_healthData.MedkitHealAmount);
        }
        else 
        {
            _playerHealthManager.HealHealth(_healthData.MedkitHealAmount);
        }
    }

    public void UseBandage()
    {
        _bandagesUsed++;
        OnBandageUse.Invoke();
        _playerHealthManager.HealHealth(_healthData.BandageHealAmount);
        if (_bandagesUsed > _healthData.StopBleedCount)
        {
            _playerHealthManager.StopBleed();
            _bandagesUsed = 0;
        }

    }

    public void UseSplint()
    {
        _splintsUsed++;
        OnSplintUse.Invoke();
        _playerHealthManager.HealHealth(_healthData.SplintHealAmount);
        if (_splintsUsed > _healthData.FixLimbCount)
        {
            _limbManager.FixLeg();
            _splintsUsed = 0;
        }
    }

}
