using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollMovement : MonoBehaviour
{
    private float speed;
    private Transform RagdollTransform;

    void Awake(){
        RagdollTransform = transform;
        speed = Random.Range(0.001f, 0.02f);
    }

    // Update is called once per frame
    void Update()
    {
        DoMovement();
    }

    private void DoMovement(){
        RagdollTransform.position += transform.right * speed;
    }
}
