using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paused : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
      Debug.Log("quit pressed");
     // Application.Quit();
     UnityEditor.EditorApplication.isPlaying = false;
    }
  

}
