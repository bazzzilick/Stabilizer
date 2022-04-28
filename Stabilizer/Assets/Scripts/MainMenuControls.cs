using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    public void TrainingButtonPressed()
    {
        SceneManager.LoadScene("Training");
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
        Debug.Log("ExitButton Pressed!");
    }


}
