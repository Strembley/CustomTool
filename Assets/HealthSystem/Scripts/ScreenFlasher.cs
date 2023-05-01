using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFlasher : MonoBehaviour
{
    [SerializeField] private HealthData _healthData;

    private int currentFlashCount = 0;  // Current number of flashes

    private Coroutine flashingCoroutine;    // Coroutine to handle flashing

    // Call this function to start flashing the UI panel
    public void StartFlashing(GameObject _panelToFlash, float _flashInterval, int _numberOfFlashes)
    {
        if (_healthData.ScreenFlashes)
        {
            if (flashingCoroutine != null)
            {
                // Stop any previous flashing coroutines
                StopCoroutine(flashingCoroutine);
            }

            // Start a new flashing coroutine
            flashingCoroutine = StartCoroutine(FlashingCoroutine(_panelToFlash, _flashInterval, _numberOfFlashes));
        }
    }

    // Call this function to stop flashing the UI panel
    public void StopFlashing(GameObject _panelToFlash)
    {
        if (flashingCoroutine != null)
        {
            // Stop the flashing coroutine
            StopCoroutine(flashingCoroutine);

            // Reset the flash count
            currentFlashCount = 0;

            // Disable the panel
            _panelToFlash.SetActive(false);
        }
    }

    private IEnumerator FlashingCoroutine(GameObject _panelToFlash, float _flashInterval, int _numberOfFlashes)
    {
        // Enable the panel
        _panelToFlash.SetActive(true);

        while (currentFlashCount < _numberOfFlashes)
        {
            // Toggle the panel's visibility
            _panelToFlash.SetActive(!_panelToFlash.activeSelf);

            // Wait for the specified interval
            yield return new WaitForSeconds(_flashInterval);

            // Increase the flash count
            currentFlashCount++;
        }

        // Disable the panel and reset the flash count and coroutine
        _panelToFlash.SetActive(false);
        currentFlashCount = 0;
        flashingCoroutine = null;
    }
}
