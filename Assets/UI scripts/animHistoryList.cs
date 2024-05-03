using System.Collections;
using System.Collections.Generic;
using General_scripts;
using TMPro;
using UI_scripts;
using UnityEngine;
using UnityEngine.UI;

public class animHistoryList : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    public GameObject buttonPrefab;
    public GameObject canvasParent;
    // Start is called before the first frame update
    void Start()
    {
        if (AnimHistory.animHistory.Count != 0)
        {
            {
                for (int i = 0; i < AnimHistory.animHistory.Count; i++)
                {
                    buttonText.text = AnimHistory.animHistory[i].getName();
                    GameObject task = Instantiate(buttonPrefab, canvasParent.transform, false);
                    task.SetActive(true);
                }
            }
        }
        else
        {
            AnimHistory.animHistory = new List<CipherAnimation>();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clear(HorizontalLayoutGroup hg)
    {
        AnimHistory.animHistory.Clear();
        // Loop through each child of the scroll rect content
        for (int i = hg.transform.childCount - 1; i >= 0; i--)
        {
            Transform child = hg.transform.GetChild(i);

            // Check if the child is not the original prefab
            if (child.gameObject != buttonPrefab)
            {
                // Destroy the child object
                Destroy(child.gameObject);
            }
        }
    }
}
