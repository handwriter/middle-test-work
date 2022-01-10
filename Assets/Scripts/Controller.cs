using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(spawnPipeIter());
    }

    public IEnumerator spawnPipeIter()
    {
        Pipe newPipe = Instantiate(Model.getInstance().pipePrefab, View.getInstance().transform).GetComponent<Pipe>();
        newPipe.setHeight(Random.Range(0, Model.getInstance().pipeSectionsCount + 1));
        yield return new WaitForSeconds(Model.getInstance().pipeSpawnTimeout);
        yield return spawnPipeIter();
    }

    public static void restartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/Level");
    }

    public static void loadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void finish()
    {
        View.getInstance().canvasUI.setScreen(0);
        Time.timeScale = 0;
        View.getInstance().canvasUI.finishScoreValue.text = View.getInstance().canvasUI.scoreValue.text;
        Model.money += Model.getInstance().Score;
        View.getInstance().canvasUI.finishMoneyValue.text = Model.money.ToString();
    }

    void Update()
    {
        
    }
}
