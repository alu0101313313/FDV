using UnityEngine;
using System.Collections;

public class TimeEffectZone : MonoBehaviour
{
    public enum EffectType {SlowMotion, FastMotion}

    [SerializeField] private EffectType effect = EffectType.SlowMotion;
    [SerializeField] private float slowScale = 0.3f;
    [SerializeField] private float fastScale = 2f;
    [SerializeField] private float duration = 2f;
    [SerializeField] private GameObject effectCamera;

    private const float defaultFixedDelta = 0.02f;
    private Coroutine routine;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.CompareTag("Player")) return;

        if(routine != null) StopCoroutine(routine);
        routine = StartCoroutine(RunEffect());
    }

    IEnumerator RunEffect()
    {
        float scale = effect == EffectType.SlowMotion ? slowScale : fastScale;

        Time.timeScale = scale;
        Time.fixedDeltaTime = defaultFixedDelta * scale;
        if(effectCamera) effectCamera.SetActive(true);

        yield return new WaitForSecondsRealtime(duration);

        ResetTime();
    }
    // Update is called once per frame
    void ResetTime()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = defaultFixedDelta;
        if (effectCamera) effectCamera.SetActive(true); 
        routine = null;       
    }

    void OnDisable()
    {
        if(routine != null) StopCoroutine(routine);
        ResetTime();
    }
}
