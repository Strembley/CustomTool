using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LimbManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;
    private ScreenFxManager _screenFxManager;
    private SfxManager _sfxManager;
    private StatusManager _statusManager;



    public bool _legBroken;
    public bool _armBroken;
    public bool _headBroken;


    public UnityEvent OnArmBreak;
    public UnityEvent OnLegBreak;
    public UnityEvent OnHeadBreak;
    public UnityEvent OnArmFix;
    public UnityEvent OnLegFix;
    public UnityEvent OnHeadFix;


    private void Awake()
    {
        _screenFxManager = GetComponent<ScreenFxManager>();
        _sfxManager = GetComponent<SfxManager>();
        _statusManager = GetComponent<StatusManager>();
    }
    public void BreakArm() 
    {
        if (_healthData.Arms)
        {
            _armBroken = true;
            _statusManager.QueueMessage("Your arm is broken", Color.red);
            OnArmBreak.Invoke();

            //Check What Order To Play Effects
            if (_healthData.FlinchSfx && !_healthData.FlinchEffect)
            {
                _sfxManager.FlinchSfxStart();
            }
            else if (!_healthData.FlinchSfx && _healthData.FlinchEffect)
            {
                _screenFxManager.FlinchStart();
            }
            else if (_healthData.FlinchSfx && _healthData.FlinchEffect)
            {
                _screenFxManager.FlinchStart();
            }

        }
    }

    public void BreakLeg()
    {
        if (_healthData.Legs)
        {
            _legBroken = true;
            _statusManager.QueueMessage("Your leg is broken", Color.red);
            OnLegBreak.Invoke();
            //Check What Order To Play Effects
            if (_healthData.FlinchSfx && !_healthData.FlinchEffect)
            {
                _sfxManager.FlinchSfxStart();
            }
            else if (!_healthData.FlinchSfx && _healthData.FlinchEffect)
            {
                _screenFxManager.FlinchStart();
            }
            else if (_healthData.FlinchSfx && _healthData.FlinchEffect)
            {
                _screenFxManager.FlinchStart();
            }


        }
    }

    public void BreakHead()
    {
        if (_healthData.Head)
        {
            _headBroken = true;
            _statusManager.QueueMessage("Your head is broken", Color.red);
            OnHeadBreak.Invoke();

            //Check What Order To Play Effects
            if (_healthData.ConcussionSfx && !_healthData.ConcussionEffect)
            {
                _sfxManager.ConcussionSfxStart();
            }
            else if (!_healthData.ConcussionSfx && _healthData.ConcussionEffect)
            {
                _screenFxManager.ConcussionStart();
            }
            else if (_healthData.FlinchSfx && _healthData.FlinchEffect)
            {
                _screenFxManager.ConcussionStart();
            }


        }
    }

    public void FixArm()
    {
        if (_healthData.Arms)
        {
            if (_armBroken == true)
            {
                _armBroken = false;
                _statusManager.QueueMessage("Your arm is fixed", Color.green);
                OnArmFix.Invoke();
            }
            
        }
    }

    public void FixLeg()
    {
        if (_healthData.Legs)
        {
            if (_legBroken == true)
            {
                _legBroken = false;
                _statusManager.QueueMessage("Your leg is fixed", Color.green);
                OnLegFix.Invoke();
            }
            
        }
    }

    public void FixHead()
    {
        if (_healthData.Head)
        {
            if (_headBroken == true)
            {
                _headBroken = false;
                _statusManager.QueueMessage("Your head is fixed", Color.green);
                OnHeadFix.Invoke();
            }
            
        }
    }

}
