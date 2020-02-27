using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Logout() {
        Debug.Log("Logout from: "+SceneManager.GetActiveScene());
        // Application.Quit();
    }
}
