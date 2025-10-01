using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolgendeScene : MonoBehaviour
{


    private void Start()
    {
        Debug.Log("Start volgende scene");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Tag" + other.tag);
        if (other.tag == "Player")
        {
            //Debug.Log("Werkt dit?");
            SceneManager.LoadScene("Dialogue");
        }
    }

}
