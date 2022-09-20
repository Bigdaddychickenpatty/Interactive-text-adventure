using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
   public void LoadNextScene()
   {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentSceneIndex + 1);
   }

   public void LoadStartScene()
   {
    SceneManager.LoadScene(0);
   }

    public void LoadBreakthruScene()
   {
    SceneManager.LoadScene(3);
   }

    public void LoadpitScene()
   {
    SceneManager.LoadScene(7);
   }
public void LoadtreeScene()
   {
    SceneManager.LoadScene(8);
   }

public void LoadcannibalScene()
   {
    SceneManager.LoadScene(6);
   }

   public void LoadScene4()
   {
    SceneManager.LoadScene(4);
   }

   public void LoaddogScene()
   {
    SceneManager.LoadScene(9);
   }

   public void LoadwinScene()
   {
    SceneManager.LoadScene(5);
   }

public void QuitGame()
{
    Application.Quit();
}

}
