using System.Collections;
using System.Collections.Generic;
using General_scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class QuizButtons : MonoBehaviour
{
    public GameObject buttonPrefab;
    public GameObject canvasParent;
    public TextMeshProUGUI textMeshPro;
    public List<Quiz> Quizzes = new List<Quiz>();
    // Start is called before the first frame update
    void Start()
    {
        Quizzes.Add(new Quiz("Enigma test", "Three questions about the enigma animation."));
        Quizzes.Add(new Quiz("MAC test", "Three questions about the MAC animation."));
        Quizzes.Add(new Quiz("SSL, TLS handshake test", "Three questions about the handshake animation."));
        Quizzes.Add(new Quiz("ECB test", "Three questions about the ECB animation."));
        foreach (Quiz current_quiz in Quizzes)
        {
            textMeshPro.text = current_quiz.QName;
            GameObject currentButton = Instantiate(buttonPrefab, canvasParent.transform, false);
            //currentButton.GetComponent<Text>() = current_quiz.QName;
            //textMeshPro.text = current_quiz.QName;


        }
        Destroy(buttonPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
