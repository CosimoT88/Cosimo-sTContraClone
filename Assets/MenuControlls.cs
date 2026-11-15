using UnityEngine;

public class MenuControlls : MonoBehaviour
{
      public void StartGame()
    {
      Debug.Log("Starting");

      UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

     public void QuitGame()
    {
      Debug.Log("Quitting");
      Application.Quit();
    }
}
