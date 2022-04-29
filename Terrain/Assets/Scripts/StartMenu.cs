using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        StartCoroutine(ChangeLevel());
    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    IEnumerator ChangeLevel()
    {
        GameObject menuController = GameObject.Find("Controller");
        float time = menuController.GetComponent<FaderScript>().BeginFade(1);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(1);
    }
}
