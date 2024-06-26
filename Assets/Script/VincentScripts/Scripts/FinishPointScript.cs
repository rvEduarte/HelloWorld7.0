using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPointScript : MonoBehaviour
{

    //[SerializeField] GameObject gameCompletion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           // gameCompletion.SetActive(true);
            Time.timeScale = 1f;
            UnlockNewLevel();
            SceneControllerScript.instance.NextLevel();
        }
    }

    void UnlockNewLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnclockLevel1", PlayerPrefs.GetInt("UnlockedLevel1", 1));
            PlayerPrefs.Save();


        }
    }
}
