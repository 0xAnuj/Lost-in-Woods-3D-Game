using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmenu : MonoBehaviour
{
   public void levelchange(){
       SceneManager.LoadScene(2);
     }
}
