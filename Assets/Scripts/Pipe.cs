using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public void setHeight(int index)
    {
        float deltaY = (Model.getInstance().maxPipeY - Model.getInstance().minPipeY) / (float)Model.getInstance().pipeSectionsCount;
        transform.position = new Vector3(transform.position.x, Model.getInstance().minPipeY + deltaY * index, transform.position.z);
    }

    public void Update()
    {
        transform.position += new Vector3(-Model.getInstance().pipeSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x <= Model.getInstance().pipeKillX)
        {
            Destroy(gameObject);
        }
    }
}
