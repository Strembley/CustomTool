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

    public void BreakArm() 
    {
        if (_healthData.Arms)
        {
            OnArmBreak.Invoke();


        }
    }

    public void BreakLeg()
    {
        if (_healthData.Legs)
        {
            OnLegBreak.Invoke();



        }
    }

    public void BreakHead()
    {
        if (_healthData.Head)
        {
            OnHeadBreak.Invoke();



        }
    }

    public void FixArm()
    {

    }

    public void FixLeg()
    {

    }

    public void FixHead()
    {

    }

}
