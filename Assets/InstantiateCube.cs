using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public GameObject prefab;



    // Start is called before the first frame update
    void Start()
    {
       
        for (int i = 0; i < 10; i++)
        {
         
                Instantiate(prefab, new Vector3(i * 5, 0, 0), Quaternion.identity);

                Debug.Log("Value is" + i);
            
        }

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
