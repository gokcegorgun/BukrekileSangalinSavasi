using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class kolonlar : MonoBehaviour
{
    public float speed ;
    void Start()
    {
        Destroy(gameObject, 15);
    }

    public void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
