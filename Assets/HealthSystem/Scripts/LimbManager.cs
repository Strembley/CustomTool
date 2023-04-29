using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LimbManager : MonoBehaviour
{
    private HealthData _healthData;

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
            if (_healthData.ScreenEffects)
            {

            }

        }
    }

    public void BreakLeg()
    {
        if (_healthData.Legs)
        {
            OnLegBreak.Invoke();
            if (_healthData.ScreenEffects)
            {

            }


        }
    }

    public void BreakHead()
    {
        if (_healthData.Head)
        {
            OnHeadBreak.Invoke();
            if (_healthData.ScreenEffects)
            {

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
