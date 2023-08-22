using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_glow_anim : MonoBehaviour
{
    public SpriteRenderer childRenderer; // Ссылка на компонент SpriteRenderer дочернего объекта
    private Color startColor;

    public float fadeDuration = 5f;
    public float delayBetweenCycles = 1f;

    private void Start()
    {
        childRenderer = GetComponentInChildren<SpriteRenderer>();
        startColor = childRenderer.color;
        StartCoroutine(FadeCycle());
    }

    private IEnumerator FadeCycle()
    {
        while (true)
        {
            yield return FadeOut();
            yield return new WaitForSeconds(delayBetweenCycles);
            yield return FadeIn();
            yield return new WaitForSeconds(delayBetweenCycles);
        }
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            Color newColor = new Color(startColor.r, startColor.g, startColor.b, alpha);
            childRenderer.color = newColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        childRenderer.color = new Color(startColor.r, startColor.g, startColor.b, 0f);
    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            Color newColor = new Color(startColor.r, startColor.g, startColor.b, alpha);
            childRenderer.color = newColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        childRenderer.color = startColor;
    }
}
