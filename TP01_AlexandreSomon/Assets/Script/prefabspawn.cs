using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabspawn : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int quantity;
    [SerializeField] private float radius;
    [SerializeField] private float timer;

    private float angle;

    private void Awake(){
        angle = 0f;
    }

    // Start is called before the first frame updates
    void Start()
    {
        StartCoroutine(StartLooping());
    }
    private IEnumerator StartLooping(){
        while(true){
            for(int i = 0; i < quantity; i++){
                angle = i * Mathf.PI * 2 / quantity;
                Instantiate(prefab, new Vector3(radius*Mathf.Cos(angle),
                                                transform.position.y,
                                                radius*Mathf.Sin(angle)),
                                                Quaternion.identity,
                                                transform);
            }
            yield return new WaitForSeconds(timer);
        }
    }
}
