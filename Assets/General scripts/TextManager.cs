using TMPro;
using UnityEngine;

namespace General_scripts
{
    public class TextManager : MonoBehaviour
    {
    
        public TextMeshProUGUI nameText;
        public TextMeshProUGUI infoText;


        public void displayText(InfoText text)
        {
            nameText.text = text.name;
            infoText.text = text.infotext;
        }


    }
}
