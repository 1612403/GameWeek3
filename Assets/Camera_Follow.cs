using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public GameObject mario;
    // Start is called before the first frame update
    Vector3 delta;
    void Start()
    {
        delta = transform.position - mario.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mario.transform.position + delta;
    }
}
