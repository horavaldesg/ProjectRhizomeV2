using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    [SerializeField] GameObject[] groundObj;
    [SerializeField] Material[] groundMat;
    Transform newTransform;
    [SerializeField]bool spawnBool;
    void Start()
    {
        newTransform = this.transform;
    }

    void Update()
    {
        if (spawnBool)
        {
            Spawn();
        }  
    }

    public void Spawn()
    {
        spawnBool = false;
        int groundR = Random.Range(0, groundObj.Length);
        int matR = Random.Range(0, groundMat.Length);
        float yPos = groundObj[groundR].transform.position.y;

        newTransform.position = new Vector3(0, this.transform.position.y + yPos, 0);
        Instantiate(groundObj[groundR], newTransform);
    }
}
