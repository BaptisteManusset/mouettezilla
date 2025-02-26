//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
  public GameObject ui;


  private void Awake()
  {
    Time.timeScale = 1;
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
    {
      Toggle();
    }

  }

  public void Toggle()
  {
    ui.SetActive(!ui.activeSelf);


    if (ui.activeSelf)
    {
      Time.timeScale = 0f;
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    } else
    {
      Time.timeScale = 1f;
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }
  }

  public void UnPause()
  {
    ui.SetActive(false);

    Time.timeScale = 1f;
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;

  }

  public void Retry()
  {
    Toggle();
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
  public void GoToMenu()
  {
    SceneManager.LoadScene(0);
  }
}
