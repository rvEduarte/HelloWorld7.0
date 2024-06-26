using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class RunningTimer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerTxt;

    [SerializeField] TextMeshProUGUI textComplete;
 
    float elapsedTime;

    [SerializeField] private Pause pauseMenu;

    public bool isPicked = false;
    //string pepe = "0:10";
  
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
            }
            else 
            {
                textComplete.text = timerTxt.text;
            }
      
            /*if(timerTxt.text == string.Format("{0:00}:{0:05}", minutes, seconds))     //FUTURE CODE NEEDED FOR ACQUIRING THE SET TIMER
            {
                Debug.Log("super10");
                Time.timeScale = 0;
            }*/
        }
    }
}
