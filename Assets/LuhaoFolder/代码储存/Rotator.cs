using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;
    void Start()
    {

    }
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);  
    }

}
