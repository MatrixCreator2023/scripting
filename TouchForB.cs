using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchForB : MonoBehaviour
{
   
    public GameObject prefab;
    private GameObject Bean;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Bean = Instantiate(prefab,transform.position,transform.rotation);

            
        }
       
            Destroy(Bean,7);
        
    }
}
