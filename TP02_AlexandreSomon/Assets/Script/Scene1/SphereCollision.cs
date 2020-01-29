using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    private static LayerMask ragdollLayer;
    private int myCounter;

        private void Awake() {
            ragdollLayer = LayerMask.NameToLayer("Ragdoll");
        }

        private void OnCollisionEnter(Collision other) {
            if (other.gameObject.layer == ragdollLayer){
                Destroy(other.transform.parent.gameObject);
                Destroy(gameObject);
                //RagdollSpawner.counter -= 1;
                //Debug.Log("Counter -1 : " + RagdollSpawner.counter);
            }
        }
}
