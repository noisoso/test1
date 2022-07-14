using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamasakusei : MonoBehaviour
{
    // bullet prefab
    public GameObject tama;

    // íeä€î≠éÀì_
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

            // íeä€ÇÃï°êª
            GameObject tamas = Instantiate(tama,transform.position, transform.rotation) as GameObject;



           



        }
    }
}
