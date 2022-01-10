using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject[] screens;
    public void onPlayBtn()
    {
        SceneManager.LoadScene("Scenes/Level");
    }

    public void setScreen(int index)
    {
        for (int i = 0;i<screens.Length;i++)
        {
            screens[i].SetActive(i == index);
        }
    }
}
