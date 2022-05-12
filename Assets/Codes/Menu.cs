using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void ChooseGuide()
    {
        SceneManager.LoadScene(1);
    } 

    public void EnterGuidedTour()
    {
        SceneManager.LoadScene(2);
    }

    public void EnterFreeTour()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("Application is quited");
        Application.Quit();
    }
}
