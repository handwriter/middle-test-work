using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasUI : MonoBehaviour
{
    public TMP_Text scoreValue;
    public TMP_Text finishScoreValue;
    public TMP_Text finishMoneyValue;
    public GameObject[] screens;

    public void setScreen(int index)
    {
        for (int i = 0; i < screens.Length; i++)
        {
            screens[i].SetActive(i == index);
        }
    }

    public void onExitBtn()
    {
        Controller.loadMenu();
    }

    public void onRestartBtn()
    {
        Controller.restartLevel();
    }

    public void onPauseBtn()
    {
        setScreen(2);
        Time.timeScale = 0;
    }

    public void onEndPauseBtn()
    {
        Time.timeScale = 1;
        setScreen(1);
    }


}
