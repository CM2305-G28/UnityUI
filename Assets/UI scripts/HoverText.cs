using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class HoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI hoverText;
    public string textToShow;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Set the text and position it near the Image
        hoverText.text = textToShow;
        hoverText.transform.position = new Vector3(transform.position.x, transform.position.y + 50f, transform.position.z);
        hoverText.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Hide the text
        hoverText.gameObject.SetActive(false);
    }
}