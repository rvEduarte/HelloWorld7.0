using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pickUpText;

    [SerializeField]
    private GameObject Greenportal;

    public GameObject jigsawPanel;

    private bool pickUpAllowed;

    public RunningTimer timer;

    // Use this for initialization
    private void Start()
    {
        jigsawPanel.SetActive(false);
        pickUpText.SetActive(false);
        Greenportal.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
            timer.isPicked = true;
            jigsawPanel.SetActive(true);

        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            
            pickUpText.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        Greenportal.SetActive(true);
        Destroy(gameObject);
    }
}
