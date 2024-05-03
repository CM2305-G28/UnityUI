using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;
using UnityEngine.Serialization;

public class HomeCircle : MonoBehaviour
{
    public Image uiCircle;
    public TextMeshProUGUI uiText;
    public float steps;
    [FormerlySerializedAs("_taskList")] public GameObject taskList;
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

    public void updateFill(){
        List<Toggle> toggles = taskList.GetComponentsInChildren<Toggle>().ToList();
        if (toggles.Count != 0)
        {
            float on=0;
            foreach (Toggle t in toggles){
                if (t.isOn){
                    on++;
                
                }
            }
            float percent = on/toggles.Count;
            uiCircle.fillAmount=percent; 
        }
        else
        {
            uiCircle.fillAmount=0; 
        }
        
        uiText.text=Math.Round(uiCircle.fillAmount*100).ToString()+"%";
    }

    public void onTaskDelete(GameObject taskList){
        List<Toggle> toggles = taskList.GetComponentsInChildren<Toggle>().ToList();
        float percent = 1/toggles.Count;
        uiCircle.fillAmount-=percent;
        uiText.text=Math.Round(uiCircle.fillAmount*100).ToString()+"%";
    }

    
}
