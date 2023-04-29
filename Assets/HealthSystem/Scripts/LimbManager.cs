using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LimbManager : MonoBehaviour
{
    private HealthData _healthData;
    private ScreenFxManager _screenFxManager;
    private SfxManager _sfxManager;



    public bool _legBroken;
    public bool _armBroken;
    public bool _headBroken;


    public UnityEvent OnArmBreak;
    public UnityEvent OnLegBreak;
    public UnityEvent OnHeadBreak;
    public UnityEvent OnArmFix;
    public UnityEvent OnLegFix;
    public UnityEvent OnHeadFix;

    public void BreakArm() 
    {
        if (_healthData.Arms)
        {
            _armBroken = true;
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
            _armBroken = false;
            OnArmFix.Invoke();
        }
    }

    public void FixLeg()
    {
        if (_healthData.Legs)
        {
            _legBroken = false;
            OnLegFix.Invoke();
        }
    }

    public void FixHead()
    {
        if (_healthData.Head)
        {
            _headBroken = false;
            OnHeadFix.Invoke();
        }
    }

}
