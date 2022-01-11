using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Coin":
                Model.getInstance().Score += Model.level;
                Destroy(other.gameObject);
                break;
            case "Finish":
                Application.getInstance().controller.finish();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5000));
            GetComponent<Rigidbody2D>().velocity = Vector3.up * 3.5f;
            GetComponent<Animator>().Rebind();
        }
    }
}
