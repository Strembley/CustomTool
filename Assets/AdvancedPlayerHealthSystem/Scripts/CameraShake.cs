using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using System.Collections;

public class CameraShake : MonoBehaviour
{

    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.1f;
    public float blurDuration = 0.5f;
    public float blurMagnitude = 0.5f;

    private float currentShakeDuration = 0f;
    private float currentBlurDuration = 0f;
    public CinemachineVirtualCamera virtualCamera;
    private CinemachineBasicMultiChannelPerlin noise;

    
    
    private void Awake()
    {
        noise = virtualCamera.GetComponentInChildren<CinemachineBasicMultiChannelPerlin>();
        
        virtualCamera.Priority = 100;
    }

    private void Start()
    {
        
    }

    public void StartShakeAndBlur(NoiseSettings _noiseProfile = null)
    {
        if (_noiseProfile != null)
        {
            noise.m_NoiseProfile = _noiseProfile;
        }
        
        virtualCamera.Priority = 100;
        currentShakeDuration = shakeDuration;
        currentBlurDuration = blurDuration;
    }

    private void Update()
    {
        if (currentShakeDuration > 0)
        {
            float shake = shakeMagnitude * (currentShakeDuration / shakeDuration);
            if (noise != null)
            {
                //Debug.Log("Theres Noise");
                noise.m_AmplitudeGain = shake;
                noise.m_FrequencyGain = shake;
            }

            currentShakeDuration -= Time.deltaTime;
        }
        else
        {
            if (noise != null)
            {
                noise.m_AmplitudeGain = 0f;
                noise.m_FrequencyGain = 0f;
                virtualCamera.Priority = 0;
            }

        }
    }
}