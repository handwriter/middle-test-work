using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour
{
    private static Application me1;

    public Model model;
    public View view;
    public Controller controller;

    public static Application getInstance()
    {
        if (me1 == null)
        {
            me1 = GameObject.Find("App").GetComponent<Application>();
        }
        return me1;
    }
}
