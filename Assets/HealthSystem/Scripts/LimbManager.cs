using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LimbManager : MonoBehaviour
{
    private HealthData _healthData;
    private ScreenFxManager _screenFxManager;
    private SfxManager _sfxManager;

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
            else
            {
                _screenFxManager.FlinchStart();
            }

        }
    }

    public void BreakLeg()
    {
        if (_healthData.Legs)
        {
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
            else
            {
                _screenFxManager.FlinchStart();
            }


        }
    }

    public void BreakHead()
    {
        if (_healthData.Head)
        {
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
            else
            {
                _screenFxManager.ConcussionStart();
            }


        }
    }

    public void FixArm()
    {
        if (_healthData.Arms)
        {
            OnArmFix.Invoke();
        }
    }

    public void FixLeg()
    {
        if (_healthData.Legs)
        {
            OnLegFix.Invoke();
        }
    }

    public void FixHead()
    {
        if (_healthData.Head)
        {
            OnHeadFix.Invoke();
        }
    }

}
