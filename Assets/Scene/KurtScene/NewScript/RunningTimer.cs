using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class RunningTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerTxt;
    [SerializeField] TextMeshProUGUI textComplete;
    [SerializeField] TextMeshProUGUI textCompletion1;
    [SerializeField] TextMeshProUGUI textCompletion2;
    [SerializeField] TextMeshProUGUI textCompletion3;

    [SerializeField] private Pause pauseMenu;

    float elapsedTime;
    public bool isPicked = false;
  
    void Update()
    {
        if (!pauseMenu.pause)
        {
            if (isPicked == false)
            {
                elapsedTime += Time.deltaTime;
                int minutes = Mathf.FloorToInt(elapsedTime / 60);
                int seconds = Mathf.FloorToInt(elapsedTime % 60);
                timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

                if(timerTxt.text == string.Format("{0:00}:{0:31}", minutes, seconds))
                {                   
                    string text1 = "100 score 30 sec.";
                    string weight1 = "#44";
                    textCompletion1.text = "<alpha=" + weight1 + ">" + text1;

                    //textCompletion1.text = "<font-weight=" +"\""+ weight1 +"\""+ ">" + text1 + "</font-weight>";
                }

                else if (timerTxt.text == string.Format("{0:00}:{0:46}", minutes, seconds))
                {
                    string text2 = "80 score 50 sec.";
                    string weight1 = "#44";
                    textCompletion2.text = "<alpha=" + weight1 + ">" + text2;
                }

                else if (timerTxt.text == string.Format("{0:00}:{1:00}", minutes, seconds))
                {
                    string text3 = "50 score 60 sec.";
                    string weight1 = "#44";
                    textCompletion2.text = "<alpha=" + weight1 + ">" + text3;
                }

            }
            else 
            {
                textComplete.text = timerTxt.text;
            }
      
            
        }
    }
}
