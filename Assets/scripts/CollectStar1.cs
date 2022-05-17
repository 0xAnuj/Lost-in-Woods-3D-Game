using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar1 : MonoBehaviour{
   
   
    void OnTriggerEnter(Collider other){
        ScoringSystem1.theScore1 += 50;
        Destroy(gameObject);
    }
    
}
