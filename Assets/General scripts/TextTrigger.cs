using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTrigger : MonoBehaviour
{
    public InfoText infotext;

    public void triggerText()
    {
        FindObjectOfType<TextManager>().displayText(infotext);
    }
}
