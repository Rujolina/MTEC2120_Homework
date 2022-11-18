using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InstantiateParticles : MonoBehaviour
{
    public GameObject prefab;
    public Transform Cube;
    public KeyCode input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(input))
        {
         Instantiate(prefab, Cube.position, transform.rotation);

        }
    }
}
