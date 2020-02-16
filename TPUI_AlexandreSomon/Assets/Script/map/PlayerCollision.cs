using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private static LayerMask death;
    
    private GameObject ChildGameObject;
    // Start is called before the first frame update
    void Awake(){
        ChildGameObject = transform.GetChild(0).gameObject;
        death = LayerMask.NameToLayer("death");
    }

    private void Update(){

    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.layer == death){
            //Function death
            print("Player dead, OOB");
        }
    }
}
