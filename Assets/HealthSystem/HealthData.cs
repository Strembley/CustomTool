using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthData_", menuName = "PlayerHealthData/Health")]
public class  HealthData : ScriptableObject
{
    
    [SerializeField]
    [Tooltip("The Players Max Health")]
    private float _maxHealth = 100;
    public float MaxHealth => _maxHealth;

    //[Separator(1, 20)]

    // Bleed


    [SerializeField]
    [Tooltip("Whether or not the player has the ability to Bleed Out")]
    private bool _bleedOut = false;
    public bool BleedOut => _bleedOut;


    [SerializeField]
    [Tooltip("Health Lost due to bleeding per second")]
    private float _bleedDamage = .02f;
    public float BleedDamage => _bleedDamage;

    [SerializeField]
    [Range(1,5)]
    [Tooltip("Increases Rate of bleeding based on bleedDamage")]
    private int _bleedIntensity = 1;
    public int BleedIntensity => _bleedIntensity;

    //[Separator(1, 20)]

    // Limb

    [SerializeField]
    [Tooltip("Whether or not the player has the ability to Lose/Damage Limbs")]
    private bool _limbLoss = false;
    public bool LimbLoss => _limbLoss;

    [SerializeField]
    [Tooltip("Whether or not the player can Break their Arms")]
    private bool _arms = false;
    public bool Arms => _arms;

    [SerializeField]
    [Tooltip("Whether or not the player can Break their Arms")]
    private bool _legs = false;
    public bool Legs => _legs;

    [SerializeField]
    [Tooltip("Whether or not the player can Cripple their Head (Concussion)")]
    private bool _head = false;
    public bool Head => _head;

    //[Separator(1, 20)]
    // FirstAid

    [SerializeField]
    [Tooltip("Whether or not the player has the ability to use FirstAid Items")]
    private bool _firstAid = false;
    public bool FirstAid => _firstAid;

    [SerializeField]
    [Tooltip("Whether or not using a medkit will stop player bleeding")]
    private bool _stopBleeding = false;
    public bool StopBleeding => _stopBleeding;

    [SerializeField]
    [Tooltip("Amount of health recovered from using a medkit")]
    private float _medkitHealAmount = 20;
    public float MedkitHealAmount => _medkitHealAmount;

    [SerializeField]
    [Tooltip("Required number of Bandages to stop bleeding")]
    private int _stopBleedCount = 1;
    public int StopBleedCount => _stopBleedCount;

    [SerializeField]
    [Tooltip("Amount of health recovered from using a bandage")]
    private float _bandageHealAmount = 0;
    public float BandageHealAmount => _bandageHealAmount;

    [SerializeField]
    [Tooltip("Required number of Splints to fix a Limb")]
    private int _fixLimbCount = 1;
    public int FixLimbCount => _fixLimbCount;

    [SerializeField]
    [Tooltip("Amount of health recovered from using a splint")]
    private float _splintHealAmount = 0;
    public float SplintHealAmount => _splintHealAmount;

    //[Separator(1, 20)]

    // VisualEffects

    [SerializeField]
    [Tooltip("Whether or not the player will experience Screen Effects based on Damage")]
    private bool _screenEffects = false;
    public bool ScreenEffects => _screenEffects;

    [SerializeField]
    [Tooltip("Whether or not the players screen will flinch on damage taken")]
    private bool _flinchEffect = false;
    public bool FlinchEffect => _flinchEffect;

    [SerializeField]
    [Tooltip("Whether or not the players screen will flash on use of FirstAid")]
    private bool _healEffect = false;
    public bool HealEffect => _healEffect;

    [SerializeField]
    [Tooltip("Whether or not the player screen will wince on limb loss (leg/arm)")]
    private bool _winceEffect = false;
    public bool WinceEffect => _winceEffect;

    [SerializeField]
    [Tooltip("Whether or not the player screen will suffer a concussion on limb loss (head)")]
    private bool _concussionEffect = false;
    public bool ConcussionEffect => _concussionEffect;




    //[Separator(1, 20)]
    // Stats

    [SerializeField]
    [Tooltip("Wether or not the players stats will be affected by different damage states")]
    private bool _affectStats = false;
    public bool AffectStats => _affectStats;

    [SerializeField]
    [Tooltip("Wether or not the players movement speed will be affected")]
    private bool _movementSpeed = false;
    public bool MovementSpeed => _movementSpeed;

    [SerializeField]
    [Range(1,10)]
    [Tooltip("The Intensity at which the player is slowed (Varies by Health Amount)")]
    private int _slowIntensity = 1;
    public int SlowIntensity => _slowIntensity;

}