using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ChangeEnding : MonoBehaviour
{
    public PlayableDirector director;
    // Start is called before the first frame update
    void Start()
    {
        if (director == null) {
            director = GameObject.Find("ChaseSequence").GetComponent<PlayableDirector>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeEndingValue(int value) {
        PersistentData.Instance.AdjustEndingCount(value);
    }

    public void PlayChaseSequence () {
        director.Play();
    }
}
