using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/
    [SerializeField] string sceneToLoad;
    public void VolgendeScene()
    {
        Debug.Log("Hallo");
        SceneManager.LoadScene(sceneToLoad);
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LevelExit")
        {
            Debug.Log("Werkt dit?");
            SceneManager.LoadScene("Battlesystem");
        }
    }*/
}
