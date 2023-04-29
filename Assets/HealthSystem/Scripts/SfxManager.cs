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


    public void FlinchSfxStart()
    {
        if (_healthData.FlinchSfx)
        {
            _audioManager.PlaySong(_flinchSfx);
        }
    }

    public void MedkitSfxStart()
    {
        if (_healthData.MedkitSfx)
        {
            _audioManager.PlaySong(_medkitSfx);
        }
    }

    public void BandageSfxStart()
    {
        if (_healthData.BandageSfx)
        {
            _audioManager.PlaySong(_bandageSfx);
        }
    }

    public void SplintSfxStart()
    {
        if (_healthData.SplintSfx)
        {
            _audioManager.PlaySong(_splintSfx);
        }
    }

    public void ConcussionSfxStart()
    {
        if (_healthData.ConcussionSfx)
        {
            _audioManager.PlaySong(_concussionSfx);
        }
    }
}
