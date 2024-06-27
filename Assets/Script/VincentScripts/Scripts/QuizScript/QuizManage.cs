using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class QuizManage : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TMP_Text questionTxt;

    public GameObject completionPanel;
    public GameObject quizPanel;
    public GameObject movingPlatform;

    public TextMeshProUGUI quizScore;

    int totalQuestions = 0;
    public int scoreCount = 0;

    private void Start()
    {
        movingPlatform.SetActive(false);
        totalQuestions = QnA.Count;
        completionPanel.SetActive(false);
        
        generateQuestion();
        //QnA.RemoveAt(currentQuestion);
    }

    public void GameOver()
    {
        completionPanel.SetActive(true);
        quizPanel.SetActive(false);
        quizScore.text = scoreCount +"/"+ totalQuestions;
    }

    public void correct()
    {
        scoreCount += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
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
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            questionTxt.text = QnA[currentQuestion].Questions;
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of question");
            GameOver();
            int sub = 9 + 5;
        }
    }
}




