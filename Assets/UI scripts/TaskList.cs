using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using General_scripts;
using TMPro;
using UI_scripts;
using UnityEngine;
using UnityEngine.UI;

public class TaskList : MonoBehaviour
{
    public GameObject taskPrefab;
    public GameObject canvasParent;
    public TextMeshProUGUI taskText;
    public Toggle taskToggle;
    public TMP_Dropdown inputBox;
    public HomeCircle hc;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Objectives.objectives.Count != 0)
        {
            {
                for (int i = 0; i < Objectives.objectives.Count; i++)
                {
                    taskText.text = Objectives.objectives[i].getTask();
                    taskToggle.isOn = Objectives.objectives[i].isComplete();
                    GameObject task = Instantiate(taskPrefab, canvasParent.transform, false);
                    task.SetActive(true);
                }
            }
        }
        else
        {
            Objectives.objectives = new List<Objective>();
        }

        hc.updateFill();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewTask(){
        //takes UI input field as arg and instantiates a task prefab with that text
        taskText.text = inputBox.options[inputBox.value].text;
        taskToggle.isOn = false;
        Debug.Log(inputBox.options[inputBox.value].text);
        GameObject task = Instantiate(taskPrefab, canvasParent.transform, false);
        task.SetActive(true);
        Objectives.objectives.Add(new Objective(inputBox.options[inputBox.value].text, false));
        hc.updateFill();
    }

    public void RemoveTask(GameObject taskToRemove){
        //takes UI input field as arg and instantiates a task prefab with that text
        RemoveObjective(taskToRemove.GetComponentInChildren<TextMeshProUGUI>().text);
        Destroy(taskToRemove);
        hc.updateFill();
    }

    private static void RemoveObjective(string task)
    {
        for (int i = 0; i < Objectives.objectives.Count; i++)
        {
            if (task == Objectives.objectives[i].getTask())
            {
                Objectives.objectives.Remove(Objectives.objectives[i]);
            }
        }
    }
    
}
