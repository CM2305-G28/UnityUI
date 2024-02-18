using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class HomeCircle : MonoBehaviour
{
    public Image uiCircle;
    public TextMeshProUGUI uiText;
    public float steps;
    // Start is called before the first frame update
    void Start()
    {
        uiCircle.fillAmount=0;
    }

    public void IncreaseFill(){
        uiCircle.fillAmount+=steps;
        uiText.text=Math.Round(uiCircle.fillAmount*100).ToString()+"%";
    }

    public void DecreaseFill(){
        uiCircle.fillAmount-=steps;
        uiText.text=Math.Round(uiCircle.fillAmount*100).ToString()+"%";
    }

    
}
