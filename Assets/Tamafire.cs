using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamafire : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;
    // bullet prefab
    public GameObject tama;

    // ’eŠÛ”­ŽË“_
    public Transform muzzle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 5.0f;
    }


    // Update is called once per frame
    void Update()
    {
       


           
            rb.velocity = transform.right * speed;





    }
}
