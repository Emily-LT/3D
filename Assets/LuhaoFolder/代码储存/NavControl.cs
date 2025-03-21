using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NavControl : MonoBehaviour
{
    public void LoadMyScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    IEnumerator PlayMySound(int sceneNumber)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScence(sceneNumber);
    }
    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
 
}
