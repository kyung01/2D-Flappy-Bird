using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector : MonoBehaviour
{
    [SerializeField] GameObject birdGObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(birdGObj.transform.position.x, this.transform.position.y, this.transform.position.z);
        
    }
}
