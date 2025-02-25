///FPS COUNTER
///Written by: Annop "Nargus" Prapasapong
///Created: 7 June 2012


using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public int FramesPerSec { get; protected set; }

    [SerializeField] private float frequency = 0.5f;


    private Text counter;

    private void Start()
    {
        counter = GetComponent<Text>();
        counter.text = "";
        StartCoroutine(FPS());
    }

    private IEnumerator FPS()
    {
        for (; ; )
        {
            int lastFrameCount = Time.frameCount;
            float lastTime = Time.realtimeSinceStartup;
            yield return new WaitForSeconds(frequency);

            float timeSpan = Time.realtimeSinceStartup - lastTime;
            int frameCount = Time.frameCount - lastFrameCount;

            FramesPerSec = Mathf.RoundToInt(frameCount / timeSpan);
            counter.text = "FPS: " + FramesPerSec.ToString();
        }
    }
}