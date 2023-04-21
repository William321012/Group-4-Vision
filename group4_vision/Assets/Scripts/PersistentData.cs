using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int NewpaperCount;
    [SerializeField] int ScrapCount;

    public static PersistentData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        NewpaperCount = 0;
        ScrapCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void SetNewpaperCount(int amount)
    {
        NewpaperCount = amount;
    }

    public void SetScrapCount(int amount)
    {
        ScrapCount = amount;
    }

    public int GetNewpaperCount()
    {
        return NewpaperCount;
    }

    public int GetScrapCount()
    {
        return ScrapCount;
    }

}
