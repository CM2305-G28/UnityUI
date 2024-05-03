using TMPro;
using UI_scripts;
using UnityEngine;
using UnityEngine.Serialization;

namespace General_scripts
{
    public class QandA : MonoBehaviour
    {
        private int _score = 0;
        private const int Total = 3;
        [FormerlySerializedAs("_scoreBox")] public TMP_InputField scoreBox;
        public string testName;
    
        public void RightAnswer()
        {
            _score++;
        }

        public void MarkAnswers()
        {
            scoreBox.text = _score + "/" + Total;
            if (_score == Total)
            {
                // put objective completion call here
                for (int i = 0; i < Objectives.objectives.Count; i++)
                {
                    if (Objectives.objectives[i].getTask() == testName)
                    {
                        Objectives.objectives[i].setComplete(true);
                        Debug.Log("Updating obj");
                        Debug.Log(Objectives.objectives[i].isComplete());
                    }
                }
                
            }
        }
        
        public void ResetAnswers()
        {
            _score = 0;
            scoreBox.text = "";
        }
    }
}
