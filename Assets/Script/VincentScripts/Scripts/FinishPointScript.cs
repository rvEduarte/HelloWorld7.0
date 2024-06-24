using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPointScript : MonoBehaviour
{

    [SerializeField] GameObject gameCompletion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameCompletion.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
