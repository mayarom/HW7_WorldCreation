using TMPro;
using UnityEngine;

public class FadeOutText : MonoBehaviour
{
    public float fadeDuration = 3f;
    public float delayBeforeFade = 2f;

    private TextMeshProUGUI textMesh;
    private float timer = 0f;
    private bool fading = false;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        SetAlpha(1f); 
        Invoke("StartFading", delayBeforeFade);
    }

    void StartFading()
    {
        fading = true;
    }

    void Update()
    {
        if (!fading) return;

        timer += Time.deltaTime;
        float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
        SetAlpha(alpha);

        if (alpha <= 0f)
        {
            gameObject.SetActive(false); 
        }
    }

    void SetAlpha(float a)
    {
        if (textMesh != null)
        {
            var color = textMesh.color;
            color.a = a;
            textMesh.color = color;
        }
    }
}
