using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    public SpawnManager spawnManager;
    int i = -1;
    public static bool artifact1 = false;
    public static bool artifact2 = false;
    public static bool artifact3 = false;
    public static bool artifact4 = false;
    public static bool artifact5 = false;
    public static bool artifact6 = false;
    public static bool artifact7 = false;
    public static bool artifact8 = false;
    public static bool artifact9 = false;
    public static bool artifact10 = false;
    public static bool artifact11 = false;
    public static bool artifact12 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collect(GameObject artifact)
    {
        for (int i = 0; i < spawnManager.artifacts.Length; i++)
        {
            if (artifact.GetComponent<ArtifactObject>().aritfactName == spawnManager.artifacts[i].GetComponent<ArtifactObject>().aritfactName)
            {
                i = artifact.GetComponent<ArtifactObject>().arrayIndex;
            }
        }
        switch (i)
        {
            case 0: artifact1 = true;
                break;
            case 1:
                artifact2 = true;
                break;
            case 2:
                artifact3 = true;
                break;
            case 3:
                artifact4 = true;
                break;
            case 4:
                artifact5 = true;
                break;
            case 5:
                artifact6 = true;
                break;
            case 6:
                artifact7 = true;
                break;
            case 7:
                artifact8 = true;
                break;
            case 8:
                artifact9 = true;
                break;
            case 9:
                artifact10 = true;
                break;
            case 10:
                artifact11 = true;
                break;
            case 11:
                artifact12 = true;
                break;

        }
        
    }
   
}
