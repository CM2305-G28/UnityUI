using System.Collections;
using System.Collections.Generic;
using General_scripts;
using TMPro;
using UI_scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetAnimationScene : MonoBehaviour
{
    public void loadAnimationScene(TextMeshProUGUI text){
        string scene_to_change_to=text.text;
        bool contains = false;
        for (int i = 0; i < AnimHistory.animHistory.Count; i++)
        {
            if (text.text == AnimHistory.animHistory[i].getName())
            {
                contains = true;
            }
        }

        if (!contains)
        {
            AnimHistory.animHistory.Insert(0,new CipherAnimation(text.text, ""));
        }
        SceneManager.LoadScene(scene_to_change_to);
    }
}
