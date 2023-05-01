using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public Text textToLerp;
    public float lerpTime = 1f; // How long it takes to lerp down
    public float displayTime = 2f; // How long to display the text before disappearing

    private RectTransform textRectTransform;
    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private float lerpStartTime;
    private bool lerping = false;
    private bool displaying = false;

    private Queue<TextMessage> messageQueue = new Queue<TextMessage>();

    private void Start()
    {
        textRectTransform = textToLerp.GetComponent<RectTransform>();
        originalPosition = textRectTransform.anchoredPosition;
        targetPosition = originalPosition - new Vector3(0f, 230f, 0f); // Lerp down 230 pixels
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
        else if (messageQueue.Count > 0 && !displaying)
        {
            TextMessage textMessage = messageQueue.Dequeue();
            textToLerp.text = textMessage.message;
            textToLerp.color = textMessage.color;
            textRectTransform.anchoredPosition = originalPosition;
            lerpStartTime = Time.time;
            lerping = true;
        }
    }

    public void QueueMessage(string message, Color color)
    {
        TextMessage textMessage = new TextMessage(message, color);
        messageQueue.Enqueue(textMessage);
    }

    private void HideText()
    {
        textToLerp.text = "";
        textToLerp.color = Color.white;
        displaying = false;
    }

    private struct TextMessage
    {
        public string message;
        public Color color;

        public TextMessage(string message, Color color)
        {
            this.message = message;
            this.color = color;
        }
    }
}
