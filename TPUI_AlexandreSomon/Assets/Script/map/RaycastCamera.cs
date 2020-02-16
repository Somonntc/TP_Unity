using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    private int layerMask = 1 << 10;
    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RaycastLaser());
    }

    private IEnumerator RaycastLaser(){
        RaycastHit hit;
        if(lineRenderer.enabled == false){
            if(Input.GetButtonDown("Fire1")){
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                    lineRenderer.enabled = true;
                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 15, Color.white);
                }
            }
        }
        else{
            yield return new WaitForSeconds(0.5f);
            lineRenderer.enabled = false;
        }
    }
}
