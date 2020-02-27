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
        // Display form
    }
    public void Quit() {
        Debug.Log("Game exit succesfully");
        Application.Quit();
    }
}
