using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggScript : MonoBehaviour
{
    Collider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 7)
        {
            StartCoroutine(WaitToDig());
            SpawnManager.ArtifactSpawner(collision.transform, col);
            //col.enabled = false; 
            collision.GetComponent<SpawnGround>().Spawn();
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator WaitToDig()
    {
        GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(0.5f);
        GetComponent<BoxCollider>().enabled = true;

    }
}
