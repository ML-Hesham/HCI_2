using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraview : MonoBehaviour
{
    public GameObject target;
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t=target.transform;
        transform.position = new Vector3 (t.position.x,t.position.y,transform.position.z);
    }
}
