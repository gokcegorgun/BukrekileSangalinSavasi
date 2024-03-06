using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class spawnerkolon : MonoBehaviour
{
    public player playerscript;
    public GameObject kolonlar;
    public float heıght;
    public float time;

    void Start()
    {
        StartCoroutine(SpawnObject(time)); 
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!playerscript.isDead)
        {
            Instantiate(kolonlar, new Vector3(9, Random.Range(-heıght, heıght), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
       
    }
}
