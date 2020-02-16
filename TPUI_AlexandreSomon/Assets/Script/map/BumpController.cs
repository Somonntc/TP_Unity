using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpController : MonoBehaviour
{
    [SerializeField] private float force = 0f;

    private void OnTriggerEnter(Collider other){
        other.GetComponent<Rigidbody>().AddForce(0, force, 0, ForceMode.Impulse);
    }
}
