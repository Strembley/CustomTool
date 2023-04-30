using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;
    [SerializeField] private AudioManager _audioManager;

    [SerializeField] private AudioClip _flinchSfx;
    [SerializeField] private AudioClip _medkitSfx;
    [SerializeField] private AudioClip _bandageSfx;
    [SerializeField] private AudioClip _splintSfx;
    [SerializeField] private AudioClip _concussionSfx;
    [SerializeField] private AudioClip _deathSfx;

    public void FlinchSfxStart()
    {
        if (_healthData.FlinchSfx)
        {
            Debug.Log("Flinch SFX Start");
            _audioManager.PlaySong(_flinchSfx);
        }
    }

    public void MedkitSfxStart()
    {
        if (_healthData.MedkitSfx)
        {
            Debug.Log("Medkit SFX Start");
            _audioManager.PlaySong(_medkitSfx);
        }
    }

    public void BandageSfxStart()
    {
        if (_healthData.BandageSfx)
        {
            Debug.Log("Bandage SFX Start");
            _audioManager.PlaySong(_bandageSfx);
        }
    }

    public void SplintSfxStart()
    {
        if (_healthData.SplintSfx)
        {
            Debug.Log("Splint SFX Start");
            _audioManager.PlaySong(_splintSfx);
        }
    }

    public void ConcussionSfxStart()
    {
        if (_healthData.ConcussionSfx)
        {
            Debug.Log("Concussion SFX Start");
            _audioManager.PlaySong(_concussionSfx);
        }
    }

    public void DeathSfxStart()
    {
        if (_healthData.DeathSfx)
        {
            Debug.Log("Death SFX Start");
            _audioManager.PlaySong(_deathSfx);
        }
    }
}
