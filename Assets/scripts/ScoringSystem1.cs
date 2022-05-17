using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem1 : MonoBehaviour{
   public GameObject scoreText;
   public static int theScore1;

   void Update()
   {
    scoreText.GetComponent<Text>().text = "Score: " + theScore1;
   }
}
