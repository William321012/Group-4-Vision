using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeEndingValue(int value) {
        PersistentData.Instance.AdjustEndingCount(value);
    }
}
