using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public GameObject pipeSpawnPoint;
    public CanvasUI canvasUI;

    public static View getInstance()
    {
        return Application.getInstance().view;
    }

}
