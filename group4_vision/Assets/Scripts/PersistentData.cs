using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] public int NewspaperCount;
    [SerializeField] public int ScrapCount;
    [SerializeField] public int EndingCount;
    [SerializeField] string playerName;
    [SerializeField] float timeSpent = 0.0f;

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
        // Testing Leaderboard
        // PlayerPrefs.DeleteAll();
    }

    // Start is called before the first frame update
    void Start()
    {
        NewspaperCount = 0;
        ScrapCount = 0;
        EndingCount = 0;
        playerName = "";
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

    public void SetName(string name)
    {
        playerName = name;
    }

    public void AddTimeSpent()
    {
        timeSpent += Time.timeSinceLevelLoad;
    }

    public void SetTimeSpentZero() {
        timeSpent = 0.0f;
    }

    public int GetNewpaperCount()
    {
        return NewspaperCount;
    }

    public int GetScrapCount()
    {
        return ScrapCount;
    }

    public int GetEndingCount()
    {
        return EndingCount;
    }

    public string GetName()
    {
        return playerName;
    }

    public float GetTimeSpent()
    {
        return timeSpent;
    }
}
