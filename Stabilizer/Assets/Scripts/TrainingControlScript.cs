using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingControlScript : MonoBehaviour
{
    public void StaticTestButtonPressed()
    {
        SceneManager.LoadScene("StaticTestScene");
    }

    public void DynamicTestButtonPressed()
    {
        SceneManager.LoadScene("DynamicTestScene");
    }

    public void BackButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
