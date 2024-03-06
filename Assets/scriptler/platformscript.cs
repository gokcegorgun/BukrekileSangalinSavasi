using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformscript : MonoBehaviour
{

    public float speed = 10f;
    public float resetPosition = -50f;

    void FixedUpdate()
    {
        // Platformu sola doğru hareket ettirme
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Platformu yeniden başa döndürme
        if (transform.position.x <= resetPosition)
        {
            RepositionPlatform();
        }
    }



    void RepositionPlatform()
    {
        // Platformu başa taşıma
        Vector3 newPosition = new Vector3(10f, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
