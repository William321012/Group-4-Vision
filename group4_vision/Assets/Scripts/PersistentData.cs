using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] public int NewspaperCount;
    [SerializeField] public int ScrapCount;
    [SerializeField] public int EndingCount;

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
        NewspaperCount = 0;
        ScrapCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void SetNewspaperCount(int amount)
    {
        NewspaperCount = amount;
    }

    public void SetScrapCount(int amount)
    {
        ScrapCount = amount;
    }

    public void SetEndingCount(int amount)
    {
        EndingCount = amount;
    }

    public int GetNewpaperCount()
    {
        return NewspaperCount;
    }

    public int GetScrapCount()
    {
        return ScrapCount;
    }

    public int GetEndingCountt()
    {
        return EndingCount;
    }
}
