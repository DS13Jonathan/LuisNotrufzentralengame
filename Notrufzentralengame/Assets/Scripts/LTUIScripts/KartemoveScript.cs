using UnityEngine;
using UnityEngine.EventSystems;

public class KartemoveScript : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    public float maxX; // Maximaler X-Wert für die Begrenzung nach rechts
    public float minX; // Minimaler X-Wert für die Begrenzung nach links
    public float maxY; // Maximaler Y-Wert für die Begrenzung nach oben
    public float minY; // Minimaler Y-Wert für die Begrenzung nach unten

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta / canvas.scaleFactor;
        Vector2 newPosition = rectTransform.anchoredPosition + delta;
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX); // Begrenze die X-Position
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY); // Begrenze die Y-Position

        rectTransform.anchoredPosition = newPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
}