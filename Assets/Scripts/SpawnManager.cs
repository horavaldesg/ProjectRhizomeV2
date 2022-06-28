using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static GameObject[] artifactsStatic;
    [SerializeField] public GameObject[] artifacts;
    // Start is called before the first frame update
    void Start()
    {
        artifacts = Resources.LoadAll<GameObject>("Artifacts");

        artifactsStatic = artifacts;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void ArtifactSpawner(Transform parent, Collider col)
    {
        Debug.Log(col.gameObject);
        for(int i = 0; i < 1; i++)
        {
            int r = Random.Range(0, artifactsStatic.Length);
            float x = Random.Range(parent.position.x - 0.5f, parent.position.x + 0.5f);
            float z = Random.Range(parent.position.z - 0.5f, parent.position.z + 0.5f);
            Vector3 objPos = new Vector3(x, parent.position.y, z);
            Instantiate(artifactsStatic[r], objPos, Quaternion.identity);
        }
        
    }
}
