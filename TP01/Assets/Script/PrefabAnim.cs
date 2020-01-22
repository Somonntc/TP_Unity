using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabAnim : MonoBehaviour
{
    [SerializeField] private float speed;
    void Awake(){
        
    }

    // Start is call ed before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 0){
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y - speed,
                transform.position.z);
        }
        if(transform.position.y <= 0){
            transform.position = new Vector3(
                transform.position.x + speed,
                transform.position.y,
                transform.position.z);
        }
        if(transform.position.x >= 10){
            Destroy(gameObject);
        }
        Debug.Log(transform.position);
    }
}
