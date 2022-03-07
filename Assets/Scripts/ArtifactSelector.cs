using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArtifactSelector : MonoBehaviour
{
    public Transform socketTrasform;
    public GameObject artifact;
    bool[] acquired;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        acquired[0] = CollectionManager.artifact1;
        acquired[1] = CollectionManager.artifact2;
        acquired[2] = CollectionManager.artifact3;
        acquired[3] = CollectionManager.artifact4;
        acquired[4] = CollectionManager.artifact5;
        acquired[5] = CollectionManager.artifact6;
        acquired[6] = CollectionManager.artifact7;
        acquired[7] = CollectionManager.artifact8;
        acquired[8] = CollectionManager.artifact9;
        acquired[9] = CollectionManager.artifact10;
        acquired[10] = CollectionManager.artifact11;
        acquired[11] = CollectionManager.artifact12;
        button = GetComponent<Button>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (artifact.GetComponent<ArtifactObject>().acquired)
        {
            ColorBlock cb = button.colors;
            cb.normalColor = Color.white;
            button.colors = cb;
        }
    }
    public void SelectArtifact()
    {
        for(int i = 0; i < acquired.Length; i++)
        {
            if (acquired[i])
            {

                Instantiate(artifact, socketTrasform);
            }
        }
       
    }
}
