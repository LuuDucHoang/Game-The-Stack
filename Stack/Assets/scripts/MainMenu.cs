using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text scoreText;
    private void Start()
    {
      
    }
    public void ToGame()
    {
        SceneManager.LoadScene("Game");

    }
}
