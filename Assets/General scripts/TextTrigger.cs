using TMPro;
using UnityEngine;

namespace General_scripts
{
    public class TextTrigger : MonoBehaviour
    {
   

        public void triggerText(string title, string body, TextMeshProUGUI canvasTitle, TextMeshProUGUI canvasBody)
        {
            canvasTitle.text = title;
            canvasBody.text = body;
        }
    }
}
