using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject prefab = default;
    [SerializeField] private Transform ballsParentTransform = default;
    private float spawningforce;
    private Transform cameraTransform;

    void Awake(){
        cameraTransform = transform;
        spawningforce = 1250;
    }

    public void SpawnBalls(){
        GameObject ball = Instantiate(prefab,
                        cameraTransform.position,
                        Quaternion.identity,
                        ballsParentTransform);
        ball.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * spawningforce);
        Destroy(ball, 2f);
    }
}
