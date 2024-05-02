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
                // // put objective completion call here
                // for (int i = 0; i < Objectives.getObjectives().Count; i++)
                // {
                //     if (Objectives.getObjectives()[i].getTask() == testName)
                //     {
                //         Objectives.getObjectives()[i].setComplete(true);
                //     }
                // }
                
            }
        }
        
        public void ResetAnswers()
        {
            _score = 0;
            scoreBox.text = "";
        }
    }
}
