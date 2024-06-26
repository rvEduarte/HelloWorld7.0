using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManage : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TMP_Text QuestionTxt;

    private void Awake()
    {
        Debug.Log("SUPER DUPER TITE");
        
        generateQuestion();
        QnA.RemoveAt(currentQuestion);
    }

    public void correct()
    {
        
        generateQuestion();
        QnA.RemoveAt(currentQuestion);
    }

    void SetAnswer ()
    {    
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrestAnswer == i+1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
            } 
        }
    }

    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestion].Questions;
        SetAnswer();
    }
}



