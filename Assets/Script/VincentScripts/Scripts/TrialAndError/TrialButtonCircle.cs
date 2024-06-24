using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class TrialButtonCircle : MonoBehaviour
{
    public Button yourButton;
    public CanvasRenderer yourDraggable1;
    public CanvasRenderer yourDraggable2;
    public CanvasRenderer yourDraggable3;
    public CanvasRenderer yourDraggable4;
    public CanvasRenderer yourDrop1;
    public CanvasRenderer yourDrop2;

    public CanvasRenderer yourCanvas;
    public CanvasRenderer yourString;
    //public CanvasRenderer yourX;

    public CanvasRenderer yourText1;
    public CanvasRenderer yourText2;
    public CanvasRenderer yourText3;
    public CanvasRenderer yourText4;
    public CanvasRenderer yourText5;
    public CanvasRenderer yourText6;

    public CanvasRenderer yourPanel;
    public CanvasRenderer yourHint;

    public bool clicked = true;
    public bool condition;

    public CanvasRenderer rightFire;

    void Start()
    {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void Update()
    {

        if (clicked == true)
        {
            //Debug.Log("HIDE");
            CanvasRenderer canvasRenderer1 = yourDraggable1.GetComponent<CanvasRenderer>();
            canvasRenderer1.cull = true;

            CanvasRenderer canvasRenderer2 = yourDraggable2.GetComponent<CanvasRenderer>();
            canvasRenderer2.cull = true;

            CanvasRenderer canvasRenderer3 = yourDraggable3.GetComponent<CanvasRenderer>();
            canvasRenderer3.cull = true;

            CanvasRenderer canvasRenderer4 = yourDraggable4.GetComponent<CanvasRenderer>();
            canvasRenderer4.cull = true;

            CanvasRenderer canvasRenderer5 = yourDrop1.GetComponent<CanvasRenderer>();
            canvasRenderer5.cull = true;

            CanvasRenderer canvasRenderer6 = yourDrop2.GetComponent<CanvasRenderer>();
            canvasRenderer6.cull = true;

            CanvasRenderer canvasRenderer7 = yourCanvas.GetComponent<CanvasRenderer>();
            canvasRenderer7.cull = true;

            CanvasRenderer canvasRenderer8 = yourString.GetComponent<CanvasRenderer>();
            canvasRenderer8.cull = true;

            // CanvasRenderer canvasRenderer999 = yourX.GetComponent<CanvasRenderer>();
            //canvasRenderer999.cull = true;

            CanvasRenderer canvasRenderer9 = yourText1.GetComponent<CanvasRenderer>();
            canvasRenderer9.cull = true;

            CanvasRenderer canvasRenderer10 = yourText2.GetComponent<CanvasRenderer>();
            canvasRenderer10.cull = true;

            CanvasRenderer canvasRenderer11 = yourText3.GetComponent<CanvasRenderer>();
            canvasRenderer11.cull = true;

            CanvasRenderer canvasRenderer12 = yourText4.GetComponent<CanvasRenderer>();
            canvasRenderer12.cull = true;

            CanvasRenderer canvasRenderer13 = yourText5.GetComponent<CanvasRenderer>();
            canvasRenderer13.cull = true;

            CanvasRenderer canvasRenderer14 = yourText6.GetComponent<CanvasRenderer>();
            canvasRenderer14.cull = true;

            CanvasRenderer canvasRenderer15 = yourPanel.GetComponent<CanvasRenderer>();
            canvasRenderer15.cull = true;

            CanvasRenderer canvasRenderer16 = yourHint.GetComponent<CanvasRenderer>();
            canvasRenderer16.cull = true;

            CanvasRenderer canvasRenderer17 = rightFire.GetComponent<CanvasRenderer>();
            canvasRenderer17.cull = true;
        }
        else if (clicked == false)
        {
            //Debug.Log("SHOW");
            CanvasRenderer canvasRenderer1 = yourDraggable1.GetComponent<CanvasRenderer>();
            canvasRenderer1.cull = false;

            CanvasRenderer canvasRenderer2 = yourDraggable2.GetComponent<CanvasRenderer>();
            canvasRenderer2.cull = false;

            CanvasRenderer canvasRenderer3 = yourDraggable3.GetComponent<CanvasRenderer>();
            canvasRenderer3.cull = false;

            CanvasRenderer canvasRenderer4 = yourDraggable4.GetComponent<CanvasRenderer>();
            canvasRenderer4.cull = false;

            CanvasRenderer canvasRenderer5 = yourDrop1.GetComponent<CanvasRenderer>();
            canvasRenderer5.cull = false;

            CanvasRenderer canvasRenderer6 = yourDrop2.GetComponent<CanvasRenderer>();
            canvasRenderer6.cull = false;

            CanvasRenderer canvasRenderer7 = yourCanvas.GetComponent<CanvasRenderer>();
            canvasRenderer7.cull = false;

            CanvasRenderer canvasRenderer8 = yourString.GetComponent<CanvasRenderer>();
            canvasRenderer8.cull = false;

            //CanvasRenderer canvasRenderer999 = yourX.GetComponent<CanvasRenderer>();
            //canvasRenderer999.cull = false;

            CanvasRenderer canvasRenderer9 = yourText1.GetComponent<CanvasRenderer>();
            canvasRenderer9.cull = false;

            CanvasRenderer canvasRenderer10 = yourText2.GetComponent<CanvasRenderer>();
            canvasRenderer10.cull = false;

            CanvasRenderer canvasRenderer11 = yourText3.GetComponent<CanvasRenderer>();
            canvasRenderer11.cull = false;

            CanvasRenderer canvasRenderer12 = yourText4.GetComponent<CanvasRenderer>();
            canvasRenderer12.cull = false;

            CanvasRenderer canvasRenderer13 = yourText5.GetComponent<CanvasRenderer>();
            canvasRenderer13.cull = false;

            CanvasRenderer canvasRenderer14 = yourText6.GetComponent<CanvasRenderer>();
            canvasRenderer14.cull = false;

            CanvasRenderer canvasRenderer15 = yourPanel.GetComponent<CanvasRenderer>();
            canvasRenderer15.cull = false;

            CanvasRenderer canvasRenderer16 = yourHint.GetComponent<CanvasRenderer>();
            canvasRenderer16.cull = false;

            CanvasRenderer canvasRenderer17 = rightFire.GetComponent<CanvasRenderer>();
            canvasRenderer17.cull = false;
        }

        
    }

    void TaskOnClick()
    {
        //Debug.Log("You have clicked the buttonCircle!");



        //disableCanvas.SetActive(true);
        //GameObject.Find("ButtonX").transform.localScale = new Vector3(1, (float)2.9, 1);
        //GameObject.Find("DraggableSlots").transform.localScale = new Vector3(1, 1, 1);
        //GameObject.Find("ButtonCircle").transform.localScale = new Vector3(0, 0, 0);
        //CanvasRenderer canvasRenderer = GetComponent<CanvasRenderer>();
        //yourCanvas = canvasRenderer;
        // yourCanvas.cull = true;
        //GetComponent<CanvasRenderer>().cull = true;

        if (clicked == true)
        {
            clicked = false;
            return;
        }
        else if(clicked == false)
        {
            clicked = true;
            return;
        }


    }
}
