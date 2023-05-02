using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    AudioSource _audioScource;

    private void Awake()
    {
        #region Singleton Pattern (Simple)
        if (Instance == null)
        {
            //Doesnt exist yet, this is now our Singleton!
            Instance = this;
            DontDestroyOnLoad(gameObject);
            // fill references
            _audioScource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion

    }

    public void PlaySong(AudioClip clip) 
    {
        _audioScource.clip = clip;
        _audioScource.Play();
    }
}
