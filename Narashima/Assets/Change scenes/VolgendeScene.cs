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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tag" + other.tag);
        if (other.tag == "NaarDialogue")
        {
            //Debug.Log("Werkt dit?");
            SceneManager.LoadScene("Dialogue");
        }
    }

}
