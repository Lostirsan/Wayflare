using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SafeAreaFitter : MonoBehaviour
{
    RectTransform panel;
    Rect lastSafeArea;

    [Header("Доп. сжатие safe area (в пикселях)")]
    public float topPaddingMinus = 10f;     
    public float bottomPaddingMinus = 10f; 

    void Awake()
    {
        panel = GetComponent<RectTransform>();
        ApplySafeArea();
    }

    void ApplySafeArea()
    {
        Rect safe = Screen.safeArea;

        safe.y += bottomPaddingMinus;        
        safe.height -= bottomPaddingMinus;     
        safe.height += topPaddingMinus;       

        if (safe == lastSafeArea)
            return;

        lastSafeArea = safe;

        Vector2 anchorMin = safe.position;
        Vector2 anchorMax = safe.position + safe.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        panel.anchorMin = anchorMin;
        panel.anchorMax = anchorMax;
    }

    void Update()
    {
        ApplySafeArea();
    }
}
