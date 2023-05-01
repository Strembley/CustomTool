using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Health&EffectsData_", menuName = "PlayerHealthData/Health")]
public class  HealthData : ScriptableObject
{
    
    [SerializeField]
    [Tooltip("The Players Max Health")]
    private float _maxHealth = 100;
    public float MaxHealth => _maxHealth;


    [SerializeField]
    [Tooltip("Whether or not status effect Notifications will pop up")]
    private bool _statusNotifications = false;
    public bool StatusNotifications => _statusNotifications;

    //[Separator(1, 20)]

    // Bleed


    [SerializeField]
    [Tooltip("Whether or not the player has the ability to Bleed Out")]
    private bool _bleedOut = false;
    public bool BleedOut => _bleedOut;


    [SerializeField]
    [Tooltip("Health Lost due to bleeding per second")]
    private float _bleedDamage = .2f;
    public float BleedDamage => _bleedDamage;

    [SerializeField]
    [Tooltip("Increases Rate of bleeding based on bleedDamage")]
    private float _bleedDelay;
    public float BleedDelay => _bleedDelay;

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
    [Tooltip("Whether or not the player has the ability to use First Aid Items")]
    private bool _firstAid = false;
    public bool FirstAid => _firstAid;

    [SerializeField]
    [Tooltip("Whether or not using a Medkit will stop player Bleeding")]
    private bool _stopBleeding = false;
    public bool StopBleeding => _stopBleeding;

    [SerializeField]
    [Tooltip("Amount of health recovered from using a Medkit")]
    private float _medkitHealAmount = 20;
    public float MedkitHealAmount => _medkitHealAmount;

    [SerializeField]
    [Tooltip("Required number of Bandages to stop Bleeding")]
    private int _stopBleedCount = 1;
    public int StopBleedCount => _stopBleedCount;

    [SerializeField]
    [Tooltip("Amount of health recovered from using a Bandage")]
    private float _bandageHealAmount = 0;
    public float BandageHealAmount => _bandageHealAmount;

    [SerializeField]
    [Tooltip("Required number of Splints to fix a Limb")]
    private int _fixLimbCount = 1;
    public int FixLimbCount => _fixLimbCount;

    [SerializeField]
    [Tooltip("Amount of health recovered from using a Splint")]
    private float _splintHealAmount = 0;
    public float SplintHealAmount => _splintHealAmount;

    //[Separator(1, 20)]

    // VisualEffects

    [SerializeField]
    [Tooltip("Whether or not the player will experience Screen Effects based on Damage")]
    private bool _screenEffects = false;
    public bool ScreenEffects => _screenEffects;


    [SerializeField]
    [Tooltip("Whether or not the player will experience Screen Flashes based on Damage/Heal Events")]
    private bool _screenFlashes = false;
    public bool ScreenFlashes => _screenFlashes;


    [SerializeField]
    [Tooltip("Whether or not the players screen will flinch on damage taken")]
    private bool _flinchEffect = false;
    public bool FlinchEffect => _flinchEffect;

    [SerializeField]
    [Tooltip("Whether or not the players screen will flash on use of First Aid")]
    private bool _healEffect = false;
    public bool HealEffect => _healEffect;

    [SerializeField]
    [Tooltip("Whether or not the player screen will suffer a concussion on limb loss (head)")]
    private bool _concussionEffect = false;
    public bool ConcussionEffect => _concussionEffect;

    //[Separator(1, 20)]

    //SFX

    [SerializeField]
    [Tooltip("Whether or not the player will experience SFX based on Health related events")]
    private bool _soundEffects = false;
    public bool SoundEffects => _soundEffects;

    [SerializeField]
    [Tooltip("Whether or not the players will experience a SFX on Flinch")]
    private bool _flinchSfx = false;
    public bool FlinchSfx => _flinchSfx;

    [SerializeField]
    [Tooltip("Whether or not the players will experience a SFX on Medkit Useage")]
    private bool _medkitSfx = false;
    public bool MedkitSfx => _medkitSfx;

    [SerializeField]
    [Tooltip("Whether or not the players will experience a SFX on Bandage Useage")]
    private bool _bandageSfx = false;
    public bool BandageSfx => _bandageSfx;

    [SerializeField]
    [Tooltip("Whether or not the players will experience a SFX on Splint Useage")]
    private bool _splintSfx = false;
    public bool SplintSfx => _splintSfx;

    [SerializeField]
    [Tooltip("Whether or not the players will experience a SFX on Concussion")]
    private bool _concussionSfx = false;
    public bool ConcussionSfx => _concussionSfx;

    [SerializeField]
    [Tooltip("Whether or not the players will experience a SFX on Death")]
    private bool _deathSfx = false;
    public bool DeathSfx => _deathSfx;
}
