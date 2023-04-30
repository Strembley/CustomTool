using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public Text textToLerp;
    public float lerpTime = 2f; // How long it takes to lerp down
    public float displayTime = 4f; // How long to display the text before disappearing

    private RectTransform textRectTransform;
    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private float lerpStartTime;
    private bool lerping = false;
    private bool displaying = false;

    private void Start()
    {
        textRectTransform = textToLerp.GetComponent<RectTransform>();
        originalPosition = textRectTransform.anchoredPosition;
        targetPosition = originalPosition - new Vector3(0f, 230f, 0f); // Lerp down 200 pixels
    }

    private void Update()
    {
        if (lerping)
        {
            float timeSinceLerpStarted = Time.time - lerpStartTime;
            float percentageComplete = timeSinceLerpStarted / lerpTime;

            if (percentageComplete >= 1f)
            {
                lerping = false;
                displaying = true;
                Invoke(nameof(HideText), displayTime);
            }
            else
            {
                textRectTransform.anchoredPosition = Vector3.Lerp(originalPosition, targetPosition, percentageComplete);
            }
        }
    }

    public void ShowText(string text)
    {
        textToLerp.text = text;
        textRectTransform.anchoredPosition = originalPosition;
        lerpStartTime = Time.time;
        lerping = true;
    }

    private void HideText()
    {
        textToLerp.text = "";
        displaying = false;
    }
}
