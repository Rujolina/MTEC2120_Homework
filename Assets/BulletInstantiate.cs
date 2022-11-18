using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletInstantiate : MonoBehaviour
{
    public GameObject prefab;
    public Transform shootingPoint;

    Rigidbody rigid;
    ConstantForce force;

    public void Shoot(InputAction.CallbackContext context)
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        force = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            Instantiate(prefab, shootingPoint.position, transform.rotation);
            rigid = GetComponent<Rigidbody>();
            force = GetComponent<ConstantForce>();
        }
    }
}
