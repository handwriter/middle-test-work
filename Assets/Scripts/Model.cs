using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    public GameObject pipePrefab;
    public int pipeSectionsCount;
    public float minPipeY;
    public float maxPipeY;
    public float pipeSpeed;
    public float pipeSpawnTimeout;
    public float pipeKillX;
    private int score;
    public Vector3 pipeSpawnCoords { get => View.getInstance().pipeSpawnPoint.transform.position; }

    public static int level
    {
        get
        {
            if (!PlayerPrefs.HasKey("level"))
            {
                PlayerPrefs.SetInt("level", 1);
            }
            return PlayerPrefs.GetInt("level");
        }
        set
        {
            PlayerPrefs.SetInt("level", value);
        }
    }

    public static int money
    {
        get
        {
            if (!PlayerPrefs.HasKey("money"))
            {
                PlayerPrefs.SetInt("money", 0);
            }
            return PlayerPrefs.GetInt("money");
        }
        set
        {
            PlayerPrefs.SetInt("money", value);
        }
    }

    public int Score
    {
        get => score;
        set
        {
            score = value;
            View.getInstance().canvasUI.scoreValue.text = score.ToString();
        }
    }

    public static Model getInstance()
    {
        return Application.getInstance().model;
    }
}
