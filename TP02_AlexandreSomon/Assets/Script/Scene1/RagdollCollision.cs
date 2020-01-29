using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollCollision : MonoBehaviour
{
    private static LayerMask wall;
    private float randomRotateY;
    void Awake(){
        wall = LayerMask.NameToLayer("Floor");
        randomRotateY = Random.Range(135, 225f);
    }

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.layer == wall){
            gameObject.transform.parent.Rotate(0f, randomRotateY, 0f);
        }
    }
}
