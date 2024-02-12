using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AnimationButtons : MonoBehaviour { 
    public GameObject buttonPrefab;
    public GameObject canvasParent;
    public TextMeshProUGUI textMeshPro;
    public List<CipherAnimation> Animations = new List<CipherAnimation>();
    // Start is called before the first frame update
    void Start()
    {
        Animations.Add(new CipherAnimation("Animation 1", "Animation 1 desc"));
        Animations.Add(new CipherAnimation("Animation 2", "Animation 2 desc"));
        Animations.Add(new CipherAnimation("Animation 3", "Animation 3 desc"));
        foreach (CipherAnimation current_CipherAnimation in Animations)
        {
            textMeshPro.text = current_CipherAnimation.AName;
            GameObject currentButton = Instantiate(buttonPrefab, canvasParent.transform, false);
            //currentButton.GetComponent<Text>() = current_CipherAnimation.QName;
            //textMeshPro.text = current_CipherAnimation.QName;


        }
        Destroy(buttonPrefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
}