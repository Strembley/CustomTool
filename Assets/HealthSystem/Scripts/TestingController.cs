using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class TestingController : MonoBehaviour
{
    private PlayerHealthManager _playerHealthManager;
    private LimbManager _limbManager;
    private FirstAidManager _firstAidManager;

    private void Awake()
    {
        _playerHealthManager = GetComponent<PlayerHealthManager>();
        _limbManager = GetComponent<LimbManager>();
        _firstAidManager = GetComponent<FirstAidManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-------------------------Bleed Controls------------------------//


        // (B) Start or Stop Bleeding
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {

            if (!_playerHealthManager._bleeding)
            {
                _playerHealthManager.StartBleed();
            }
           

        }



        //-------------------------Limb Controls/First Aid------------------------//

        // (L) Break Leg
        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            if (!_limbManager._legBroken)
            {
                _limbManager.BreakLeg();
            }
            else
            {
                _firstAidManager.UseSplint();
            }
        }




        // (O) Break Arm
        if (Keyboard.current.oKey.wasPressedThisFrame)
        {
            if (!_limbManager._armBroken)
            {
                _limbManager.BreakArm();
            }
            else
            {
                _firstAidManager.UseSplint();
            }

        }


        // (P) Break Head
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            if (!_limbManager._headBroken)
            {
                _limbManager.BreakHead();
            }
            else
            {
                _firstAidManager.UseSplint();
            }

        }

        // (N) Bandage
        if (Keyboard.current.nKey.wasPressedThisFrame)
        {
           
              _firstAidManager.UseBandage();
        }


        // (M) Medkit
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            _firstAidManager.UseMedkit();
        }


        //-------------------------???? Controls------------------------//a



    }

}
