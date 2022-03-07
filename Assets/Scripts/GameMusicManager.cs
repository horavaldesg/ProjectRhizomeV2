using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class GameMusicManager : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    public FMODUnity.EventReference fmodEvent;

    int i = 0;
    float duration = 13;
    float timer;

    private void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();

    }
    private void Update()
    {
        //Debug.Log(timer);
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            timer = 0;
            i = Random.Range(1, 3);
            instance.setParameterByName("Music", i);

        }
    }
}
