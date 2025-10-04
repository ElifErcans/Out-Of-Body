using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject[] menuPanels;
    void Start()
    {
        menuPanels = GameObject.FindGameObjectsWithTag("MenuPanel");
    }
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        foreach (GameObject panel in menuPanels)
        {
            panel.gameObject.SetActive(false);
            Debug.Log(panel.name);
        }

    }
    public void QuitGame()
    {
        Debug.Log("ehe");
        Application.Quit();
    }
}
