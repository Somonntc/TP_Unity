using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject ragdollPrefab = default;
    [SerializeField] private Transform SpawnCoordinate = default;
    [SerializeField] private float timer = 2f;
    [SerializeField] private int limit = 10;
    public static int counter;

    void Awake(){
        counter = 0;
    }
    void Start()
    {
        StartCoroutine(DoSpawns());
    }

    private IEnumerator DoSpawns() {
            while (true) {
                if(counter <= limit){
                    Instantiate(ragdollPrefab, SpawnRandomPosition(), GetRandomRotation(), SpawnCoordinate);
                    //counter += 1;
                    //Debug.Log("Counter +1 : " + counter);
                    yield return new WaitForSeconds(timer);
                }
                //else{
                //    yield return new WaitForSeconds(timer);
                //}
            }
        }

    private Vector3 SpawnRandomPosition(){
        return new Vector3(
            Random.Range(-19f, 19f),
            Random.Range(1.5f, 4f),
            Random.Range(-19f, 19f)
        );
    }

    private static Quaternion GetRandomRotation() {
            return Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }
}
