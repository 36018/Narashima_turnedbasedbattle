using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolgendeScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "NaarDialogue")
        {
            //Debug.Log("Werkt dit?");
            SceneManager.LoadScene("Dialogue");
        }
    }

}
