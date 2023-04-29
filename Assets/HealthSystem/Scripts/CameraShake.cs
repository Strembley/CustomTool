using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{

    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.1f;
    public float blurDuration = 0.5f;
    public float blurMagnitude = 0.5f;

    private Vector3 originalPos;
    private float originalFov;
    private float currentShakeDuration = 0f;
    private float currentBlurDuration = 0f;
    public CinemachineVirtualCamera virtualCamera;
    private CinemachineBasicMultiChannelPerlin noise;


    private void Awake()
    {
        //cinemachineBrain = GetComponent<CinemachineBrain>();
        //virtualCamera = cinemachineBrain.ActiveVirtualCamera.VirtualCameraGameObject.GetComponent<CinemachineVirtualCamera>();
        noise = virtualCamera.GetComponentInChildren<CinemachineBasicMultiChannelPerlin>();
        
        virtualCamera.Priority = 100;
    }

    private void Start()
    {
        originalPos = transform.localPosition;
        originalFov = virtualCamera.m_Lens.FieldOfView;
        
    }

    public void StartShakeAndBlur(NoiseSettings _noiseProfile)
    {
        noise.m_NoiseProfile = _noiseProfile;
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
            }
        }

        if (currentBlurDuration > 0)
        {
            float blur = blurMagnitude * (currentBlurDuration / blurDuration);
            if (virtualCamera != null)
            {
                virtualCamera.m_Lens.FieldOfView += blur;
            }

            currentBlurDuration -= Time.deltaTime;
        }
        else
        {
            if (virtualCamera != null)
            {
                virtualCamera.m_Lens.FieldOfView = originalFov;
            }

            transform.localPosition = originalPos;
            virtualCamera.Priority = 0;
        }
    }
}