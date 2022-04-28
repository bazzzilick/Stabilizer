using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum TestState
{
    READY,
    RUN,
    PAUSED,
    СOMPLETED
}


public class StaticTestController : MonoBehaviour
{

    public TestState testState = TestState.READY;
    public float testDuration = 5;

    public Text startStopButtonText;
    public Timer timer;
    //public BalanceCursor balanceCursor;
    //public 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timeValue > testDuration)
        {
            timer.timeRunning = false;
            testState = TestState.СOMPLETED;
            startStopButtonText.text = "Завершить";
        }

        switch (testState)
        {
            case TestState.READY:
                
                break;
            case TestState.RUN:
                Debug.Log("Save position to container");
                break;
            case TestState.PAUSED:
                
                break;
            case TestState.СOMPLETED:
               
                break;
        }

    }

    public void StartStopStaticTest()
    {
        switch (testState)
        {
            case TestState.READY:
                testState = TestState.RUN;
                Debug.Log("testState: RUN");
                timer.timeRunning = true;
                startStopButtonText.text = "Пауза";
                break;
            case TestState.RUN:
                testState = TestState.PAUSED;
                Debug.Log("testState: PAUSED");
                timer.timeRunning = false;
                startStopButtonText.text = "Старт";
                break;
            case TestState.PAUSED:
                testState = TestState.RUN;
                Debug.Log("testState: RUN");
                timer.timeRunning = true;
                startStopButtonText.text = "Пауза";
                break;
            case TestState.СOMPLETED:
                //save result of test from container to file
                break;
        }


        //testRunning = !testRunning;
        //timer.timeRunning = !timer.timeRunning;
        //создание файла с результатами или массива;

    }

    public void StartStopButtonPressed()
    {
        StartStopStaticTest();
    }

    public void ResetButtonPressed()
    {
        switch (testState)
        {
            case TestState.READY:
                break;

            case TestState.RUN:
                timer.timeRunning = false;
                timer.timeValue = 0;

                //TODO clear result array
                
                testState = TestState.READY;
                Debug.Log("testState: READY");
                break;

            case TestState.PAUSED:
                timer.timeRunning = false;
                timer.timeValue = 0;

                //TODO clear result array
                
                testState = TestState.READY;
                Debug.Log("testState: READY");
                break;

            case TestState.СOMPLETED:
                break;
        }
   
    }

    public void EscapeButtonPressed()
    {
        SceneManager.LoadScene("Training");
    }

}
