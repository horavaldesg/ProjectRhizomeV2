using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactStorage : MonoBehaviour
{
    public CollectionManager collectionManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Artifact"))
        {
            collectionManager.Collect(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
