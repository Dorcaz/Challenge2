using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProSpinPropellerX : MonoBehaviour
{

    public GameObject propeller;
    

    private Vector3 offset = new Vector3(0, 0, 4);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = propeller.transform.position + offset;
    }
}
